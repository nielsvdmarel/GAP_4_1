using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	
	void Start () {
		// we halen de component op die IWeapon implementeert en roepen Shoot() aan
		// vanuit Player weten we nu niet of het een HandGun, ShotGun of misschien zelfs een scud raketsysteem of gewoon een simpel knopje om een atoomwapen af te laten gaan
		// zodoende zijn we super 'loosely coupled'
		// ik hoef alleen maar te weten wat ik aan kan roepen op het component. Daar zorgt de interface voor.
		// verder maakt het mij vanuit deze Class totaal niet uit wie of wat het is
		// Zodoende is deze Class net zo vrij als het F35 vliegtuig die we vorige week bekeken in de presentatie
		gameObject.GetInterface<IWeapon>().Shoot();
	}

	void Update () {
		// door de extension methods is de method SetPositionX beschikbaar
		transform.SetPositionX( Random.Range(-10.0F, 10.0F) );
	}
}
