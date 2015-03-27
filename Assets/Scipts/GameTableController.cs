using UnityEngine;
using System.Collections;

public class GameTableController : MonoBehaviour {

	// March 25, 2015
	//DONE Build a deck of cards
	//DONE Deal out 5 cards to the player
	//DONE Take the 5 cards out of the deck
	//DONE Display the 5 cards for the player

	// March 26, 2015
	//TODO Populate deck to 48 cards
	//TODO W1-8, H1-8, V1-8
	//TODO Each card should be in the deck twice
	//TODO Shuffle the deck before dealing out 5 cards
	//TODO Comment code

	public GameObject playerHand;
	public GameObject playerCard;
	public GameObject gameDeck;

	private int deckSize;
	private CardController[] deck;

	// Use this for initialization
	void Start () {

		// Building the deck
		gameDeck.GetComponent<DeckController> ().Shuffle ();

		// Dealing out cards
		DealCardsToPlayer ();
	}

	void DealCardsToPlayer() {

		// Getting a pointer to the deck and player hand
		DeckController deckC = gameDeck.GetComponent<DeckController> ();
		HandController handC = playerHand.GetComponent<HandController> ();

		// Loops through the player hand and adds a card off the top of the deck
		for (int x = 0; x<handC.cards.Length; x++) {

			// Adds a card to player hand with an index that matches the index of the top card of the deck
			handC.AddCard(x, deckC.TopCardIndex(), true);

			// Hides the top card of the deck to simulate dealing the card out
			deckC.HideTopCard();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
