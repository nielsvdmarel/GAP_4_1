using UnityEngine;
using System.Collections;

public class MulticastScript : MonoBehaviour 
{

	// we declareren de 'handtekening' van de Multicast delegate
	delegate void GameObjectMover();

	// vervolgens maken we een variabele aan die kan refereren naar verschillende methods
	GameObjectMover MoveGameObject;	
	
	void Start () 
	{

		// we voegen een functie toe aan de delegate
		MoveGameObject += MoveRight;
		// we voegen NOG een functie toe aan de delegate
		MoveGameObject += MoveUp;

	}

	void FixedUpdate() {

		// ALTIJD checken of je delegate niet NULL is. Anders krijg je errors
		if(MoveGameObject != null)
		{
			// er is/zijn 1 of meerdere delegate referenties: laten we ze aanroepen
			MoveGameObject();
		}
	}


	void OnMouseDown() {
		// als voorbeeld halen we 1 van de functies weg als je op dit gameobject klikt
		MoveGameObject -= MoveRight;
	}



	// eerste functie die gebruikt kan worden voor een delegate
	void MoveRight()
	{
		Debug.Log("Move to the right");
	}

	// tweede functie die gebruikt kan worden voor een delegate
	void MoveUp()
	{
		Debug.Log("Move up");
	}
}
