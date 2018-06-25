using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideScroller_Part2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			Application.LoadLevel ("Gameshop");
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			Application.LoadLevel ("Gameshop 2");
		}
	}
}
