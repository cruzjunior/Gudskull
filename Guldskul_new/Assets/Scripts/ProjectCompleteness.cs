using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectCompleteness : MonoBehaviour
{
    private GameObject ongoingLine;
    private GameObject almostLine;
    private GameObject cancelledLine;

    public GameObject propellerCanvas;
    public GameObject bumperCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void setLines(GameObject on, GameObject al, GameObject can)
    {
        ongoingLine = on;
        almostLine = al;
        cancelledLine = can;
    }

    public void onGoing()
    {
        ongoingLine.SetActive(true);
        almostLine.SetActive(false);
        cancelledLine.SetActive(false);
    }

    public void Almost()
    {
        ongoingLine.SetActive(false);
        almostLine.SetActive(true);
        cancelledLine.SetActive(false);
    }

    public void Cancelled()
    {
        ongoingLine.SetActive(false);
        almostLine.SetActive(false);
        cancelledLine.SetActive(true);
    }

    public void Next()
    {
        propellerCanvas.SetActive(false);
        bumperCanvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
