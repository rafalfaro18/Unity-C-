using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_3_Arrays_List : MonoBehaviour {

	public string[] playerNames = new string[3];
	public List<string> enemyrNames = new List<string>();

	// Use this for initialization
	void Start () {
		playerNames[0] = "john";
		playerNames[1] = "jane";
		playerNames[2] = "bob";

		enemyrNames.Add("Boss 1");
		enemyrNames.Add("Big Boss");
		enemyrNames.Add("Bigger Boss");

		Debug.Log("Player name is"+playerNames[1] + "boss is "+enemyrNames[2]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
