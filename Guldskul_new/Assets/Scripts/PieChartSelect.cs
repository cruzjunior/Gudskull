using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieChartSelect : MonoBehaviour
{
    public GameObject past;
    public GameObject current;
    public GameObject future;

    private void Start()
    {
        past.SetActive(true);
        current.SetActive(false);
        future.SetActive(false);
    }

    public void Past()
    {
        past.SetActive(true);
        current.SetActive(false);
        future.SetActive(false);
    }

    public void Current()
    {
        past.SetActive(false);
        current.SetActive(true);
        future.SetActive(false);
    }

    public void Future()
    {
        past.SetActive(false);
        current.SetActive(false);
        future.SetActive(true);
    }

}
