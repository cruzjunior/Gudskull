using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour
{
    public Animator drawer;
    public GameObject four;
    public GameObject three;
    public GameObject draw;
    public GameObject control;

    bool isUp = false;
    bool isRight = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DrawerControl()
    {
        if (!isUp)
        {
            isUp = true;
            drawer.SetTrigger("up");
        }
        else
        {
            isUp = false;
            drawer.SetTrigger("down");
        }
    }

    public void Right()
    {
        if (!isRight)
        {
            drawer.SetTrigger("right");
            isRight = true;
        }
        else
        {
            drawer.SetTrigger("left");
            isRight = false;
        }
    }

    public void Draw()
    {
        draw.SetActive(true);
        control.SetActive(true);
    }

    public void Finish()
    {
        draw.SetActive(false);
        control.SetActive(false);
    }

    public void Next()
    {
        gameObject.transform.SetParent (four.transform);
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, gameObject.transform.position.y, 0);
        if (isUp)
        {
            drawer.SetTrigger("down");
            isUp = false;
        }
        if (isRight)
        {
            isRight = false;
        }
        
        
    }

    public void Back()
    {
        gameObject.transform.SetParent (three.transform);
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, gameObject.transform.position.y, 0);
        if (isUp)
        {
            drawer.SetTrigger("down");
            isUp = false;
        }
        if (isRight)
        {
            isRight = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
