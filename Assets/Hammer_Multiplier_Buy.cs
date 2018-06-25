using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer_Multiplier_Buy : MonoBehaviour {
	public void Buy_Multiplier_Function(){
		if (Cocoadd.coins > 499) {
			Cocoadd.coinLoss (500);
			Cocoadd.cocomulti_thingy ();
		}
	}
}
