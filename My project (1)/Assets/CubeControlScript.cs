using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CubeControlScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) { transform.position += Vector3.forward * Time.deltaTime; }
        if (Input.GetKey(KeyCode.A)) { transform.position += Vector3.left * Time.deltaTime; }
        if (Input.GetKey(KeyCode.S)) { transform.position += Vector3.back * Time.deltaTime; }
        if (Input.GetKey(KeyCode.D)) { transform.position += Vector3.right * Time.deltaTime; }


    }
    
}
