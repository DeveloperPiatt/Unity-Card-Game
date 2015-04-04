using UnityEngine;
using System.Collections;

public class CardController : MonoBehaviour {

	public int cardIndex;
	public Texture[] faces;
	public Texture background;
	public Texture outline;

	public void ShowBackground() {

		// Make sure the card is visible and displaying the background texture
		GetComponent<Renderer> ().enabled = true;
		GetComponent<Renderer> ().material.mainTexture = background;
	}

	public void HideCard() { 

		// Hiding the card from view
		GetComponent<Renderer> ().enabled = false;
	}

	public void ShowFace() {

		// Make sure the card is visible and displaying the face corresponding to the cardIndex
		GetComponent<Renderer> ().enabled = true;
		GetComponent<Renderer> ().material.mainTexture = faces[cardIndex];
	}

	public void ShowCardOutline() {

		// Mark sure the card is visible and displaying the card outline
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
