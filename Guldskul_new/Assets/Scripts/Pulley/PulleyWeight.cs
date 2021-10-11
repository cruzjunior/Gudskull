using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulleyWeight : MonoBehaviour
{
    public int weight = 0;

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "weight 5":
                StartCoroutine(AddWeight(5));
                break;
            case "weight 10":
                StartCoroutine(AddWeight(10));
                break;
            case "weight 15":
                StartCoroutine(AddWeight(15));
                break;
        }
    }

    IEnumerator AddWeight(int w)
    {
        yield return new WaitForSeconds(0.5f);
        weight += w;
    }
}
