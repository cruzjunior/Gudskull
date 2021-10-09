using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableDraw : MonoBehaviour
{
    public Drawing draw;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnPointerEnter()
    {
        draw.enabled = false;
    }

    public void OnPointerExit()
    {
        draw.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
