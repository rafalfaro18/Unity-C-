using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_4_Enum : MonoBehaviour {

	public enum LevelOfDifficulty { easy, medium, hard, difficult };

	public LevelOfDifficulty levelOfDifficulty = LevelOfDifficulty.easy;

	// Use this for initialization
	void Start () {
		Debug.Log("starting level of difficulty: " + levelOfDifficulty);
		levelOfDifficulty = LevelOfDifficulty.hard;
		Debug.Log("starting level of difficulty" + levelOfDifficulty);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
