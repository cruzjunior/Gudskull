using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Obi;

public class Load : MonoBehaviour
{
    public GameObject hook;
    bool attached;
    bool landed;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "hook")
        {
            attached = true;  
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "hook")
        {
            attached = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    transform.parent = null;
        //    gameObject.AddComponent<Rigidbody>();
        //    attached = false;
        //}

        //if (Input.GetKeyDown(KeyCode.Q) && attached)
        //{
        //    Destroy(gameObject.GetComponent<Rigidbody>());
        //    transform.parent = hook.gameObject.transform;
        //    transform.rotation = hook.transform.rotation;          
        //}
    }
}
