using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlowManager : MonoBehaviour
{
    public GameObject[] pages = new GameObject[4];
    public int centre;
    public bool isBiodata;

    public GameObject dt;
    public GameObject df;
    public Drawing d;
    public GameObject drawingBiodata;

    public GameObject draw;

    bool moveForward = false;
    bool moveBack = false;
    public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        centre = 0;
    }

    public void MoveForward_Biodata()
    {
        moveForward = true;
        drawingBiodata.SetActive(false);
    }

    public void MoveBack_Biodata()
    {
        moveBack = true;
        drawingBiodata.SetActive(true);
    }

    public void MoveForward_SetpThree()
    {
        moveForward = true;
        d.SetP(dt);
        dt.SetActive(true);
    }

    public void MoveForward_SetpFour()
    {
        moveForward = true;
        d.SetP(df);
        dt.SetActive(false);
        df.SetActive(true);
    }

    public void MoveBack_SetpThree()
    {
        moveBack = true;
        d.SetP(dt);
        dt.SetActive(true);
        df.SetActive(false);
    }

    public void MoveBack_SetpFour()
    {
        moveBack = true;
        d.SetP(df);
        df.SetActive(true);
    }

    public void MoveF()
    {
        moveForward = true;
        df.SetActive(false);
    }

    public void move_Forward()
    {
        moveForward = true;
    }

    public void move_Back()
    {
        moveBack = true;
    }

    public void NextScene()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {

        if (moveForward)
        {
            if(pages[centre + 1].gameObject.GetComponent<RectTransform>().anchoredPosition.x > 0)
            {                
                float xCentreOther = pages[centre + 1].gameObject.GetComponent<RectTransform>().anchoredPosition.x;               
                pages[centre + 1].gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(xCentreOther + (-speed * Time.deltaTime), 0);
            }

            if(pages[centre].gameObject.GetComponent<RectTransform>().anchoredPosition.x > -1900)
            {
                float xCentre = pages[centre].gameObject.GetComponent<RectTransform>().anchoredPosition.x;
                pages[centre].gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(xCentre + (-speed * Time.deltaTime), 0);
            }

            else
            {
                pages[centre + 1].gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
                pages[centre].gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(-1900, 0);
                moveForward = false;
                centre++;
            }
            
        } 

        if (moveBack)
        {
            if (pages[centre - 1].gameObject.GetComponent<RectTransform>().anchoredPosition.x < 0)
            {
                float xCentreOther = pages[centre - 1].gameObject.GetComponent<RectTransform>().anchoredPosition.x;
                pages[centre - 1].gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(xCentreOther + (speed * Time.deltaTime), 0);
            }

            if (pages[centre].gameObject.GetComponent<RectTransform>().anchoredPosition.x < 1900)
            {
                float xCentre = pages[centre].gameObject.GetComponent<RectTransform>().anchoredPosition.x;
                pages[centre].gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(xCentre + (speed * Time.deltaTime), 0);
            }

            else
            {
                pages[centre - 1].gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
                pages[centre].gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(1900, 0);
                moveBack = false;
                centre--;
            }
        }

        if(pages[centre].name == "draw")
        {
            draw.SetActive(true);
        }

        else if (isBiodata)
        {
            draw.SetActive(false);
        }
        
    }
}
