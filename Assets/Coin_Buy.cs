using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Buy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Coin_Buy_With_The_Coconuts(){
		if (Cocoadd.coconuts > 99) {
			Cocoadd.coconutLoss (100);
			Cocoadd.coinBuy (50);
		}
	}
	public void Mega_Buy_With_The_Coconuts(){
		if (Cocoadd.coconuts > 1999) {
			Cocoadd.coconutLoss (2000);
			Cocoadd.coinBuy (1000);
		}
	}
}
