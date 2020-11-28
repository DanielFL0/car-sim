using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscillatingObstacle : MonoBehaviour
{
    [SerializeField] Vector3 movementVector = new Vector3(10f, 0f, 0f);
    [SerializeField] float period = 2f;
    [Range(0, 1)]
    [SerializeField]
    float movementFactor; // 0 for not moved, 1 for fully moved

    Vector3 startingPoint;
    // Start is called before the first frame update
    void Start()
    {
        startingPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (period <= Mathf.Epsilon)
        {
            return;
        }
        float cycles = Time.time / period;
        const float tau = Mathf.PI * 2f;
        float sineWave = Mathf.Sin(cycles * tau);

        movementFactor = sineWave / 2F + 0.5f;
        Vector3 offset = movementFactor * movementVector;
        transform.position = startingPoint + offset;
    }
}
