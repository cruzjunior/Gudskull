using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BumperActivation : MonoBehaviour
{
    public TMP_InputField text;
    public GameObject back;

    public float xScale;
    public float yScale;

    float x;
    float y;

    // Start is called before the first frame update
    void Start()
    {
        x = gameObject.GetComponent<RectTransform>().anchoredPosition.x;
        y = gameObject.GetComponent<RectTransform>().anchoredPosition.y;
    }

    public void Selected()
    {
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -370);
        gameObject.GetComponent<RectTransform>().localScale = new Vector2(xScale, yScale);
        text.enabled = true;
        back.SetActive(true);
    }

    public void Back()
    {
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);
        gameObject.GetComponent<RectTransform>().localScale = new Vector2(1, 1);
        text.enabled = false;
        back.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
