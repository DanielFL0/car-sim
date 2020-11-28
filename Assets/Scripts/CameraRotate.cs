using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{

    public GameObject obj;
    public float speed;


    // Update is called once per frame
    void Update()
    {
        OrbitAround();     
    }

    void OrbitAround()
    {
        transform.RotateAround(obj.transform.position, Vector3.up, speed * Time.deltaTime);
    }

}
