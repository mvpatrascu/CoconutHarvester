using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slave_Multiplier : MonoBehaviour {
	public void Add_Slave_Multiplier(){
		if (Cocoadd.coins > 4999) {
			Cocoadd.coinLoss (5000);
			Cocoadd.coco_per_frame_multi_thingy_i_guess ();
		}
	}
}
