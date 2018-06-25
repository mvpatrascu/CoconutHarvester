using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Coconutdisplayer : MonoBehaviour {
	public Text text;
	// Use this for initialization
	void Start () {
		text.text = "Coconuts:0";
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Coconuts:" + Cocoadd.coconuts;
	}				//Welcome to Coconutdisplayer, or is it display? I have no idea.............................................................................
}
