using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavedCharacter : MonoBehaviour
{
    public CharacterCreator cc;

    // Start is called before the first frame update
    void Start()
    {
        cc.SpawnPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
