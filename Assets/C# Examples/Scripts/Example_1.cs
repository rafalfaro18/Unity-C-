using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_1 : MonoBehaviour {

	public string message = "Hello World";

	void Awake () {
		Debug.Log("I'm First!");
	}
	
	// Use this for initialization
	void Start () {
		Debug.Log(message);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("How are you?");
	}
}
