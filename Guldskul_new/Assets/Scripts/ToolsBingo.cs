using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsBingo : MonoBehaviour
{
    public Color colour;
    public GameObject draw;
    public GameObject bingo;
    public GameObject drawManager;
    public GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Draw()
    {
        draw.SetActive(true);
        bingo.SetActive(false);
        drawManager.SetActive(true);
        drawManager.GetComponent<Drawing>().SetP(parent);
    }

    public void FinishDraw()
    {
        draw.SetActive(false);
        bingo.SetActive(true);
        drawManager.SetActive(false);
    }

    public void Yellow()
    {
        colour = new Color(255, 255, 0, 100);
    }
    public void Blue()
    {
        colour = new Color(0, 0, 255, 100);
    }
    public void Black()
    {
        colour = new Color(0, 0, 0, 100);
    }
}
