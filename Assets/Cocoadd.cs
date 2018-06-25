using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cocoadd : MonoBehaviour {
	public static int coconuts;
	public static int cpc;
	public static int cocomulti;
	public static int coco_per_frame;
	public static int coco_per_frame_multiplier;
	public static int coins;
	//Why are you reading the code? Leave right now!!!!!!!!!!!!!!!1!!!!111!!!!!!!!!!!!!!!!!!!111111111
	public static void coconutAdd(int number_one){
		coconuts = coconuts + number_one;
	}
	public static void coconutLoss(int number_two){
		coconuts = coconuts - number_two;
	}
	public static void coinBuy(int duck_you){
		coins = coins + duck_you;
	}
	public static void coinLoss(int number_three_i_guess){
		coins = coins - number_three_i_guess;
	}
	public static void cpc_thingy(){
		cpc = cpc + 1;
	}
	public static void cocomulti_thingy(){
		cocomulti = cocomulti + 1;
	}
	public static void coco_per_click_thingy_idk(){
		coco_per_frame = coco_per_frame + 1;    //Yes I know to function names don't make any sense, deal with it!!!!!
	}
	public static void coco_per_frame_multi_thingy_i_guess(){
		coco_per_frame_multiplier = coco_per_frame_multiplier + 1;
	}
	void Start(){
		coconuts = 0;
		cocomulti = 1;
		cpc = 1;
		coco_per_frame_multiplier = 1;
		coco_per_frame = 0;
	}							//And you're still reading, leave for once!
	void Update (){	
		//Please dont steal my beautiful code    );
	}
	public void CoconutAdd(){

	}
}
//No, you stole it (or just read my comments in this file)!!!!!!!!!!!!111!!!!11111!!!!