using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_3_Arrays_List : MonoBehaviour {

	string[] playerNames = new string[3];

	// Use this for initialization
	void Start () {
		playerNames[0] = "john";
		playerNames[1] = "jane";
		playerNames[2] = "bob";

		Debug.Log("Player name is"+playerNames[1]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
