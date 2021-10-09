using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Obi;

public class CraneController : MonoBehaviour {

	ObiRopeCursor cursor;
	ObiRope rope;
    public GameObject retractor;
    public float retractSpeed = 0.75f;

	// Use this for initialization
	void Start () {
		cursor = GetComponentInChildren<ObiRopeCursor>();
		rope = cursor.GetComponent<ObiRope>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)){
			if (rope.restLength > 6.5f)
				cursor.ChangeLength(rope.restLength - 1f * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.S)){
			cursor.ChangeLength(rope.restLength + 1f * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.D)){
			transform.Rotate(0,Time.deltaTime*30f,0);
		}

		if (Input.GetKey(KeyCode.A)){
			transform.Rotate(0,-Time.deltaTime*30f,0);
		}

        if (Input.GetKey(KeyCode.Z) && retractor.transform.localPosition.x > 6)
        {
            retractor.transform.position -= retractor.transform.right * 0.003f;
            cursor.ChangeLength(rope.restLength - retractSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.C) && retractor.transform.localPosition.x < 9.5f)
        {
            retractor.transform.localPosition = new Vector3(retractor.transform.localPosition.x + 0.003f, retractor.transform.localPosition.y, retractor.transform.localPosition.z);
            cursor.ChangeLength(rope.restLength + retractSpeed * Time.deltaTime);
        }
    }
}
