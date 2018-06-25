using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class The_Last_Sidescroller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			Application.LoadLevel("Gameshop 1");
		}
	}
}
