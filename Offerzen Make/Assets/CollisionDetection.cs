using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detect ahahah");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
