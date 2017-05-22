using System;
using UnityEngine;
using System.Collections;


public class DelegateScript : MonoBehaviour 
{

	Action<int> MoveGameObject;
	
	// ! mag ook als local variable gemaakt worden
			
	void Start () 
	{

		// we laten de delegate variabele refereren naar de functie GoRight
		MoveGameObject = MoveLeft;

		// en we roepen de delegate aan
		MoveGameObject(100);

		// we laten de delegate variabele refereren naar de functie GoLeft
		MoveGameObject = MoveRight;

		// en we roepen de delegate aan
		MoveGameObject(89);
	}

	void MoveLeft(int speed){
		Debug.Log ("we gaan naar links met de snelheid: " + speed);
	}

	void MoveRight(int speed){
		Debug.Log ("we gaan naar rechts met de snelheid: " + speed);
	}



}
