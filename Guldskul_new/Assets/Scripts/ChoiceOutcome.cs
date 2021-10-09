using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceOutcome : MonoBehaviour
{
    public GameObject next;
    public MapNavigation mN;
    public AnimationClip anim;
    public AnimationClip backAnim;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void nextP()
    {
        mN.next(next, anim, backAnim);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
