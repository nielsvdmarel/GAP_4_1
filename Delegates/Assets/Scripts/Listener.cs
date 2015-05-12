using UnityEngine;

public class Listener : MonoBehaviour
{
	void Awake () 
	{
		// Deze Class wil weten wanneer het geluid klaar is met spelen
		// daarvoor registreert hij zich voor de OnSoundCompleted Event / CallBack
		SoundPlayer.SoundCompleted += ContinueGame;

		SoundPlayer.LoadSound("muziek.mp3", SoundLoaded);

	}

	void ContinueGame()
	{
		print ("event is called, we should continue: " + this.name);
	}

	void SoundLoaded( string data )
	{
		print (data);
	}

}