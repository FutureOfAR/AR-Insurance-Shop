using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheWorld : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Made it");
        var bob = new {
            name        = "Bob",
            policy_id   = "1IN3TNDA2T",
            age         = 46
        };
        Debug.Log(string.Format("Here is bob {0}", bob.name)); 
	}
	
	// Update is called once per frame
    void Update () {
        
    }
}
