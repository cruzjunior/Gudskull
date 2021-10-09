using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFlow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void FromBiodata()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void FromLevelOne()
    {
        //SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
    public void FromLevelTwo()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }
    public void FromLevelThree()
    {
        SceneManager.LoadScene(3, LoadSceneMode.Single);
    }
    public void FromLevelFour()
    {
        SceneManager.LoadScene(4, LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
