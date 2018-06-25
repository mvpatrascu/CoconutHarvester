using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slave_Buy : MonoBehaviour {
	public void Slave_Buy_Function (){
		if (Cocoadd.coins > 999) {
			Cocoadd.coinLoss (1000);
			Cocoadd.coco_per_click_thingy_idk ();
		}
	}
}
