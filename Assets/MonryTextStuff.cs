using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MonryTextStuff : MonoBehaviour {
	public Text coin_number;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		coin_number.text = "Coins:" + Cocoadd.coins;
	}
}
