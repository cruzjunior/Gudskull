using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulleyLevel : MonoBehaviour
{
    private float pulleOneWeight;
    private float pulleTwoWeight;

    private const float dist = -5f;

    public GameObject pulleyOne;
    public GameObject pulleyTwo;

    float oneYPos = 0;
    float twoYPos = 0;

    float total;

    // Start is called before the first frame update
    void Start()
    {
        LeanTween.init(500);

        pulleOneWeight = pulleyOne.transform.GetChild(0).GetComponent<PulleyWeight>().weight;
        pulleTwoWeight = pulleyTwo.transform.GetChild(0).GetComponent<PulleyWeight>().weight;

        float totalWeight = pulleOneWeight + pulleTwoWeight;
        oneYPos = (pulleOneWeight / totalWeight) * dist;
        twoYPos = (pulleTwoWeight / totalWeight) * dist;

        total = totalWeight;

        Animate();
    }

    // Update is called once per frame
    void Update()
    {
        
        pulleOneWeight = pulleyOne.transform.GetChild(0).GetComponent<PulleyWeight>().weight;
        pulleTwoWeight = pulleyTwo.transform.GetChild(0).GetComponent<PulleyWeight>().weight;

        float totalWeight = pulleOneWeight + pulleTwoWeight;
        oneYPos = (pulleOneWeight / totalWeight) * dist;
        twoYPos = (pulleTwoWeight / totalWeight) * dist;

        if (totalWeight != total)
        {
            Animate();
        }

        total = totalWeight;
    }

    void Animate()
    {
        LeanTween.moveLocalY(pulleyOne, oneYPos, 1);
        LeanTween.moveLocalY(pulleyTwo, twoYPos, 1);
    }

}
