using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectWeight : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;

    public GameObject weightFive;
    public GameObject weightTen;
    public GameObject weightFifteen;

    Vector3 mousePosition;

    GameObject activeWeight = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition.z = 10;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                switch (hit.collider.tag)
                {
                    case "weight 5":  
                        GameObject newWeightFive = Instantiate(weightFive, new Vector3(mousePosition.x, mousePosition.y, 0), Quaternion.identity);
                        newWeightFive.transform.localScale = new Vector3(newWeightFive.transform.localScale.x, newWeightFive.transform.localScale.y, newWeightFive.transform.localScale.y);
                        activeWeight = newWeightFive;
                        break;
                    case "weight 10":
                        GameObject newWeightTen = Instantiate(weightTen, new Vector3(mousePosition.x, mousePosition.y, 0), Quaternion.identity);
                        newWeightTen.transform.localScale = new Vector3(newWeightTen.transform.localScale.x, newWeightTen.transform.localScale.y, newWeightTen.transform.localScale.y);
                        activeWeight = newWeightTen;
                        break;
                    case "weight 15":
                        GameObject newWeightFifteen = Instantiate(weightFifteen, new Vector3(mousePosition.x, mousePosition.y, 0), Quaternion.identity);
                        newWeightFifteen.transform.localScale = new Vector3(newWeightFifteen.transform.localScale.x, newWeightFifteen.transform.localScale.y, newWeightFifteen.transform.localScale.y);
                        activeWeight = newWeightFifteen;
                        break;
                }
            }
                
        }
        Debug.Log(mousePosition);
        if(activeWeight != null)
        { 
            activeWeight.transform.position = new Vector3(mousePosition.x, mousePosition.y, 0);
        }

        if (Input.GetMouseButtonUp(0))
        {
            activeWeight.GetComponent<Rigidbody>().isKinematic = false;
            activeWeight = null;
        }

    }
}
