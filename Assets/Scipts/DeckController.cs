using UnityEngine;
using System.Collections;

public class DeckController : MonoBehaviour {

	public GameObject[] cards;
	public int[] randomFaces;
	
	private int topCard;

	public void Shuffle() {

		// Gets the first card n the deck
		CardController aCard = cards [0].GetComponent<CardController> ();

		// Determining how many different card faces a card can have
		int facesInt = aCard.faces.Length;

		// Generating an array that stores all the cards that should be in the deck
		randomFaces = new int[facesInt];
		for (int x = 0; x<facesInt; x++) {
			randomFaces[x] = x;
		}

		// Assigns each card in the deck an index and puts the card face down
		for (int x = 0; x<cards.Length; x++) {
			CardController thisCard = cards[x].GetComponent<CardController> ();
			thisCard.cardIndex = randomFaces[x];
			thisCard.ShowBackground();

			// keeps track where the top card pointer is at
			topCard = x;
		}

		print ("Assigned all cards in deck an index");
	}

	public void HideTopCard() {

		// Making sure there are cards in the deck
		if (topCard > 0) {
			// still cards left to give out!
			// Grabbing the top card of the deck
			CardController tCard = cards [topCard].GetComponent<CardController> ();

			// Hiding the top card
			tCard.HideCard ();

			// Moving the top card counter to the next card in the deck
			topCard--;
		}

	}

	public int TopCardIndex() {
		// Returns the index of the current top card
		CardController tCard = cards [topCard].GetComponent<CardController> ();
		return tCard.cardIndex;
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
