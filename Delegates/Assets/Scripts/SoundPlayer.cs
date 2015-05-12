using UnityEngine;
using System.Collections;

public class SoundPlayer : MonoBehaviour
{
	
	// we declareren een handtekening zonder parameters (mag ook met)
	public delegate void SoundCompletedEventHandler(); // events geven we qua benaming altijd de suffix EventHandler

	// we declareren de daadwerkelijke variabele die kan verwijzen naar methods
	public static event SoundCompletedEventHandler SoundCompleted;

	public delegate void SoundLoadedCallback(string data);

	/*
	 * Waarom zijn delegates & events handig?
	 * - ze kunnen je helpen met het switchen tussen states
	 * - super handig voor herbruikbaarheid
	 * - ze helpen je met encapsulation. Je brengt meer een API aan in je code en daardoor wordt je code meer 'loosely coupled'
	 * */


	void OnMouseDown()
	{
		Dispatch();
	}
	
	void Dispatch()
	{
		if(SoundCompleted != null)
		{
			SoundCompleted();
		}
	}

	// functie om bijvoorbeeld een muziekbestand te laden
	public static void LoadSound(string url, SoundLoadedCallback callback)
	{
		// als het bestand geladen is dan voeren we de callback uit
		// nu gebeurd dit synchroon (direct), maar dit zou ook vertraagd kunnen gebeuren doordat
		// je asynchroon data ophaalt van de server, of van de computer, of omdat je een coroutine uitvoert
		// je zou bijvoorbeeld bij pathfinding een functie kunnen maken: findPath(start, end, callback)
		// als het pad is gevonden (asynchroon want dan krijg je geen hickups) dan wordt de callback uitgevoerd waarbij
		// je het pad doorgeeft
		callback("dit is mijn data");
	}

}
