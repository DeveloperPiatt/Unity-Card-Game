using UnityEngine;
using System.Collections;

public class CardController : MonoBehaviour {

	public int cardIndex;
	public Texture[] faces;
	public Texture background;
	public Texture outline;

	public void ShowBackground() {
		GetComponent<Renderer> ().enabled = true;
		GetComponent<Renderer> ().material.mainTexture = background;
		//renderer.material.mainTexture = background;
	}

	public void HideCard() { 
		GetComponent<Renderer> ().enabled = false;
	}

	public void ShowFace() {
		GetComponent<Renderer> ().enabled = true;
		GetComponent<Renderer> ().material.mainTexture = faces[cardIndex];
	}

	public void ShowCardOutline() {
		GetComponent<Renderer> ().enabled = true;
		GetComponent<Renderer> ().material.mainTexture = outline;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
