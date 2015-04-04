using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CardCon : MonoBehaviour {

	public int cardIndex;
	public Sprite[] faces;
	public Sprite background;
	public Sprite outline;
	
	public void ShowBackground() {
		
		// Make sure the card is visible and displaying the background texture

		GetComponent<Image> ().enabled = true;
		GetComponent<Image> ().sprite = background;
		//GetComponent<Renderer> ().enabled = true;
		//GetComponent<Renderer> ().material.mainTexture = background;
	}
	
	public void HideCard() { 
		
		// Hiding the card from view
		GetComponent<Image> ().enabled = false;
		//GetComponent<Renderer> ().enabled = false;
	}
	
	public void ShowFace() {
		
		// Make sure the card is visible and displaying the face corresponding to the cardIndex
		GetComponent<Image> ().enabled = true;
		GetComponent<Image> ().sprite = faces[cardIndex];
	}
	
	public void ShowCardOutline() {
		
		// Mark sure the card is visible and displaying the card outline
		GetComponent<Image> ().enabled = true;
		GetComponent<Image> ().sprite = outline;
	}
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
