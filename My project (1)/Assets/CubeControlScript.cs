using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CubeControlScript : MonoBehaviour
{
    Rigidbody myRB;
    
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) { transform.position += transform.forward * Time.deltaTime; }
        if (Input.GetKey(KeyCode.A)) { transform.position += Vector3.left * Time.deltaTime; }
        if (Input.GetKey(KeyCode.S)) { transform.position -= transform.forward * Time.deltaTime; }
        if (Input.GetKey(KeyCode.D)) { transform.position += Vector3.right * Time.deltaTime; }
        if (Input.GetKey(KeyCode.Space)) { myRB.AddForce(transform.forward, ForceMode.Force); }


    }
    
}
