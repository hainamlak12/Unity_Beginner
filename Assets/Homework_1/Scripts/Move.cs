using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour 
{
    BoxCollider Box;
    // Start is called before the first frame update
    void Start()
    {
        Box = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update() // cam getcomponent o ham update
    {


        // if (Input.GetKey(KeyCode.A))
        // {
        //     transform.Translate(Vector3.left * Time.deltaTime);
        // }
        // if (Input.GetKey(KeyCode.D))
        // {
        //     transform.Translate(Vector3.right * Time.deltaTime);
        // }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime); //up la bay len ****** forward la di ve truoc
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime); //down la chim xuong ****** back la di lui
        }
        
    }
}
