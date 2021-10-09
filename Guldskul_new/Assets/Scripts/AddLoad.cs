using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AddLoad : MonoBehaviour
{
    public GameObject load;
    GameObject spawnedLoad;
    public TMP_InputField input;
    public GameObject canvasInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void AddText()
    {
        spawnedLoad.GetComponentInChildren<TextMesh>().text = input.text;
        canvasInput.SetActive(false);
    }

    public void Add()
    {
        Vector3 spawnPoint = new Vector3(Random.Range(-1.0f, 1.0f), 0, Random.Range(0f, 1.0f));
        spawnPoint = spawnPoint.normalized;
        float magnitude = Random.Range(7, 10);
        spawnPoint = spawnPoint * magnitude;

        spawnedLoad = Instantiate(load, spawnPoint, Quaternion.identity);

        canvasInput.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
