using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {


	void Start () {
		GetTexture();
	}

	void GetTexture(){
		// we kunnen de textureloader nu makkelijk hergebruiken. TextureLoader weet helemaal niets van Enemy.cs
		TextureLoader textureLoader = new TextureLoader();
		textureLoader.Load("http://etenswaardig.net/wp-content/uploads/2013/02/aardappelhart.png",
		                   TextureLoaded,
		                   this); // this verwijst naar dit gameobject
	}

	void TextureLoaded(Texture texture){
		Renderer renderer = GetComponent<Renderer>();
		renderer.material.mainTexture = texture;
	}

}
