using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BingoOptions : MonoBehaviour
{
    public ToolsBingo tb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        gameObject.GetComponent<SpriteRenderer>().color = tb.colour;
    }

    private void OnMouseEnter()
    {
        //Debug.Log("pressed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
