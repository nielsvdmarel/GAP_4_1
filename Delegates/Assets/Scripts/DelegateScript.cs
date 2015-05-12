using UnityEngine;
using System.Collections;


public class DelegateScript : MonoBehaviour 
{

	// we declareren de 'handtekening' van deze delegate
	// dit noemen we de delegate template. Nu kunnen we variabelen aanmaken met het type GameObjectMover
	delegate void GameObjectMover(int speed); // delegates hebben een benaming als: ValueExtractor, MessageSender, etc. Soms krijgt hij de suffix Callback

	// vervolgens maken we een variabele aan die kan refereren naar de delegate
	// deze variabele heeft als 'type' GameObjectMover (de handtekening die we hierboven hebben gedeclareerd)
	// een delegate is een container van een functie (soort functie pointer)
	GameObjectMover MoveGameObject; // benaming als werkwoord (zoals bij functies): send, shoot, etc.
			
	void Start () 
	{

		// we laten de delegate variabele refereren naar de functie GoRight
		MoveGameObject = GoRight;

		// en we roepen de delegate aan
		MoveGameObject(50);

		// we laten de delegate variabele refereren naar de functie GoLeft
		MoveGameObject = GoLeft;

		// en we roepen de delegate aan
		MoveGameObject(50);
	}


	void GoRight(int speed)
	{
		Debug.Log("We should go right with speed: " + speed);
	}
	
	void GoLeft(int speed)
	{
		Debug.Log("We should go left with speed: " + speed);
	}
}
