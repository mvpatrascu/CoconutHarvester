 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer_Buy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Hammer_Buy_Function(){
		if (Cocoadd.coins > 99) {
			Cocoadd.coinLoss (100);
			Cocoadd.cpc_thingy ();
		}
	}
	public void Hammer_Buy_Functsdion(){
		if (Cocoadd.coins > 499) {
			Cocoadd.coinLoss (500);
			Cocoadd.cpc_thingy ();
			Cocoadd.cpc_thingy ();
			Cocoadd.cpc_thingy ();
			Cocoadd.cpc_thingy ();
			Cocoadd.cpc_thingy ();
		}
	}
}
