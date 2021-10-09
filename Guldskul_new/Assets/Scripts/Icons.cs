using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icons : MonoBehaviour
{
    public GameObject icons;
    public GameObject iconsTwo;
    public FlowManager fm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDrag()
    {
        if(fm.centre == 3)
        {
            gameObject.transform.position = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            gameObject.transform.SetParent (icons.gameObject.transform);
        }
        else if(fm.centre == 4)
        {
            gameObject.transform.position = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            gameObject.transform.SetParent (iconsTwo.gameObject.transform);
        }


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
