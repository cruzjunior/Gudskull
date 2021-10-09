using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulley : MonoBehaviour
{
    public GameObject platformOne;
    public GameObject platformTwo;
    public GameObject bucket;

    float oneAmount = 0;
    float twoAmount = 0;

    int bucketHeight = 0;

    public void AddPlatOne()
    {
        oneAmount++;
        if(oneAmount > twoAmount)
        {
            MoveDown(platformOne, 0.5f);
            MoveUp(platformTwo, 0.5f);
        }
        else if(oneAmount <= twoAmount)
        {
            MoveDown(platformOne, 1);
            MoveUp(bucket, 1);
            bucketHeight++;
        }
    }

    public void RemovePlatOne()
    {     
        if (oneAmount > twoAmount && bucketHeight == 0)
        {
            MoveDown(platformTwo, 0.5f);
            MoveUp(platformOne, 0.5f);
        }
        else if (oneAmount <= twoAmount)
        {
            MoveUp(platformOne, 1);
            MoveDown(bucket, 1);
            bucketHeight--;
        }
        oneAmount--;
    }

    public void RemovePlatTwo()
    {
        
        if (twoAmount > oneAmount && bucketHeight == 0)
        {
            MoveUp(platformTwo, 0.5f);
            MoveDown(platformOne, 0.5f);
        }
        else if (twoAmount <= oneAmount)
        {
            MoveUp(platformTwo, 1);
            MoveDown(bucket, 1);
            bucketHeight--;
        }
        twoAmount--;
    }

    public void AddPlatTwo()
    {       
        twoAmount++;
        if (twoAmount > oneAmount)
        {
            MoveDown(platformTwo, 0.5f);
            MoveUp(platformOne, 0.5f);
        }
        else if (twoAmount <= oneAmount)
        {
            MoveDown(platformTwo, 1);
            MoveUp(bucket, 1);
            bucketHeight++;
        }
    }

    void MoveUp(GameObject go, float y)
    {
        go.transform.position = new Vector3 (go.transform.position.x, go.transform.position.y + y, go.transform.position.z);
    }

    void MoveDown(GameObject go, float y)
    {
        go.transform.position = new Vector3(go.transform.position.x, go.transform.position.y - y, go.transform.position.z);
    }
}
