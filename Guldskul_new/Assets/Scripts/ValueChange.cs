using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ValueChange : MonoBehaviour
{
    public PieChart pc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ValueChanged()
    {
        string name = gameObject.name;
        Debug.Log("here");

        float value = float.Parse(this.gameObject.GetComponent<TMP_InputField>().text);

        if (this.gameObject.GetComponent<TMP_InputField>().text == "")
        {
            value = 0;
        }

        switch (name)
        {
            case "cash":
                pc.values[0] = value;
                break;
            case "saving":
                pc.values[1] = value;
                break;
            case "investing":
                pc.values[2] = value;
                break;
            case "loan":
                pc.values[3] = value;
                break;
        }

        pc.SetValues(pc.values);
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
