using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    [SerializeField] private float speed;

    [SerializeField] private Rigidbody rigidBody;

    [SerializeField] private Vector3 inputVector;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Forward()
    {
        rigidBody.AddRelativeForce(Vector3.up * 100f * Time.deltaTime);
    }

    void Left()
    {
        rigidBody.AddRelativeForce(Vector3.left * 100f * Time.deltaTime);
    }

    void Right()
    {
        rigidBody.AddRelativeForce(Vector3.right * 100f * Time.deltaTime);
    }

    void Backward()
    {
        rigidBody.AddRelativeForce(-Vector3.up * 100f * Time.deltaTime);
    }
    void ZoomIn()
    {
        rigidBody.AddRelativeForce(Vector3.forward * 100f * Time.deltaTime);
    }
    void ZoomOut()
    {
        rigidBody.AddRelativeForce(-Vector3.forward * 100f * Time.deltaTime);
    }

    void RespondToInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Forward();
        }
        if (Input.GetKey(KeyCode.A))
        {
            Left();
        }
        if (Input.GetKey(KeyCode.S))
        {
            Backward();
        }
        if (Input.GetKey(KeyCode.D))
        {
            Right();
        }
        if (Input.GetKey(KeyCode.Q))
        {
            ZoomIn();
        }
        if (Input.GetKey(KeyCode.E))
        {
            ZoomOut();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // inputVector = new Vector3(Input.GetAxisRaw("Horizontal") * 10f, rigidBody.velocity.y, Input.GetAxisRaw("Vertical") * 10f);
        // rigidBody.velocity = inputVector;
        RespondToInput();
    }
}
