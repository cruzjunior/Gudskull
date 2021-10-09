using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BladeSelect : MonoBehaviour
{
    //public GameObject blade;

    public GameObject onGoingB;
    public GameObject cancelledB;
    public GameObject almostB;

    public GameObject onGoingLine;
    public GameObject cancelledLine;
    public GameObject almostLine;

    public ProjectCompleteness pc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Selected()
    {
        onGoingB.GetComponent<Button>().enabled = true;
        cancelledB.GetComponent<Button>().enabled = true;
        almostB.GetComponent<Button>().enabled = true;

        pc.setLines(onGoingLine, almostLine, cancelledLine);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
