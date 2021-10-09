using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    public float distance = 2;
    GameObject load;
    public float offset = 0.3f;
    bool inRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position, Vector3.down, out hit ,distance) && hit.collider.gameObject.tag == "load")
        {
            Debug.Log(hit.collider.gameObject.name);
            load = hit.collider.gameObject;
            inRange = true;
        }
        else
        {
            inRange = false;
            load = null;
        }

        if (Input.GetKeyDown(KeyCode.Q) && inRange && load != null)
        {
            
            load.transform.position = new Vector3(load.transform.position.x, transform.position.y - offset, load.transform.position.z);
            load.transform.parent = gameObject.transform;
            load.transform.rotation = gameObject.transform.rotation;
            //Destroy(load.GetComponent<Rigidbody>());
            StartCoroutine(Wait());
        }

        if (Input.GetKeyDown(KeyCode.E) && load != null)
        {
            load.transform.parent = null;
            load.AddComponent<Rigidbody>();
            load = null;

        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.1f);
        Destroy(load.GetComponent<Rigidbody>());
    }

}
