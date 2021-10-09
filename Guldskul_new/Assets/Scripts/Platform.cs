using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    List<GameObject> loads = new List<GameObject>();
    public Pulley p;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "load" && !loads.Contains(collision.gameObject))
        {
            collision.gameObject.transform.parent = gameObject.transform;
            loads.Add(collision.gameObject);
            if (gameObject.name == "Platform 1")
            {
                p.AddPlatOne();
            }
            else if (gameObject.name == "Platform 2")
            {
                p.AddPlatTwo();
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("exit");
        if (collision.gameObject.tag == "load" && loads.Contains(collision.gameObject))
        {
            Debug.Log("exit");
            //collision.gameObject.transform.parent = null;
            loads.Remove(collision.gameObject);
            if (gameObject.name == "Platform 1")
            {
                p.RemovePlatOne();
            }
            else if (gameObject.name == "Platform 2")
            {
                p.RemovePlatTwo();
            }
        }
    }
}
