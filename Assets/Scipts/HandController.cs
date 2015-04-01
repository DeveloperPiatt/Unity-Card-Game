using UnityEngine;
using System.Collections;

public class HandController : MonoBehaviour {

	public GameObject[] cards;
	public int clientID;

	// Use this for initialization

	public void AddCard (int cardId, int cardIndex, bool showFaceUp) {

		// cardID -> Determines which card spot in the hand we are adding a card to
		// cardIndex -> Determines which card texture to display when the card runs showFace()
		// showFaceUp -> Tells us to either show the face or the card back
		CardController cardController = cards [cardId].GetComponent<CardController> ();

		// Assigning the card the index being passed in
		cardController.cardIndex = cardIndex;

		// Displays the card face up or face down
		if (showFaceUp) {
			cardController.ShowFace ();
		} else {
			cardController.ShowBackground();
		}
	}	

	public void Reset() {
		print ("Clearing all cards");
		// Goes through the hand and clears out all the cards in hand
		CardController firstCardController = cards [0].GetComponent<CardController> ();
		firstCardController.cardIndex = 0;
		firstCardController.ShowCardOutline();

		for (int x = 1; x < cards.Length; x++) {
			CardController cardController = cards[x].GetComponent<CardController>();
			cardController.HideCard();
		}
		print ("Cards cleared");
	}

	void Start () {
	
		//Reset ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
