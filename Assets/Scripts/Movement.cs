using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{

    public Camera cam;
    public UnityEngine.AI.NavMeshAgent agent;
    static Vector3 destination;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetDestination();
    }

    void GetDestination()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            
            if (Physics.Raycast(ray, out hit))
            {
                destination = hit.point;
                Debug.Log(hit.point);
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Vector3 cubePos = destination;
                cubePos.y += 1.0f;
                cube.transform.position = cubePos;
                
                cube.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
                agent.SetDestination(hit.point);
            }   
        }
    }

    void destroyDestinationPoint()
    {
    }

    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.name == "Cube")
        {
            GameObject activeObject = GameObject.Find("Cube");
            Destroy(activeObject);
        }
    }

    void StartGame()
    {
        int nextSceneToLoad;
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneToLoad);
    }

}
