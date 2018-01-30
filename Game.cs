using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	// Use this for initialization
	void Start () {
	StartGame();

		
	}
	
	void StartGame (){

		max = 1000;
		min = 1;
		guess = 500;
		
		print ("____________________________");
		print ("Welcome to Number Wizard");
		
		print ("Pick a number between " + min + "and "+ max + ", but don't tell me.");
		
		print ("Is the number higher or lower than "+guess +"?");
		print ("Press the Up Arrow for higher, Down Arrow for lower, or return if the number has been chosen");
		print ("____________________________");
		
		max = max+1;
	}
	
	void NextGuess() {
		guess = (max + min) /2;
		print("Higher or lower than " + guess +"?");
		print ("Press the Up Arrow for higher, Down Arrow for lower, or return if the number has been chosen");
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			min = guess;
			NextGuess();

		}
		else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.Return)) {
			print("I won!!");
			StartGame();
		}
	}
}
