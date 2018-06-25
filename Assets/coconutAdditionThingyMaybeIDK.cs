using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coconutAdditionThingyMaybeIDK : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Cocoadd.coconutAdd (Cocoadd.coco_per_frame * Cocoadd.coco_per_frame_multiplier);
	}
	public void coconutClick(){
		Cocoadd.coconutAdd (Cocoadd.cpc * Cocoadd.cocomulti);
	}
}
