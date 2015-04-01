using UnityEngine;
using System.Collections;

public class GameTableController : MonoBehaviour {

	// March 25, 2015
	//DONE Build a deck of cards
	//DONE Deal out 5 cards to the player
	//DONE Take the 5 cards out of the deck
	//DONE Display the 5 cards for the player

	// March 26, 2015
	//DONE Populate deck to 48 cards
	//DONE W1-8, H1-8, V1-8
	//DONE Each card should be in the deck twice
	//DONE Shuffle the deck before dealing out 5 cards
	//DONE Comment code

	// March 31
	//TODO Add player 2 hand
	//TODO Add player 3 hand
	//TODO Add player 4 hand
	//TODO Comment code

	// Hands of cards
	public GameObject playerHand;
	public GameObject cpu2Hand;
	public GameObject cpu3Hand;
	public GameObject cpu4Hand;

	// Quick reference to a normal card
	public GameObject playerCard;

	// Game deck
	public GameObject gameDeck;

	private int deckSize;
	private CardController[] deck;

	// Use this for initialization
	void Start () {

		// Building the deck
		gameDeck.GetComponent<DeckController> ().Shuffle ();

		// Dealing out cards
		DealCardsToHand (playerHand, true);
		DealCardsToHand (cpu2Hand, false);
		DealCardsToHand (cpu3Hand, false);
		DealCardsToHand (cpu4Hand, false);
	}

	void DealCardsToHand(GameObject hand, bool faceUp) {
		// Getting a pointer to the deck and player hand
		DeckController deckC = gameDeck.GetComponent<DeckController> ();
		HandController handC = hand.GetComponent<HandController> ();

		// Loops through the player hand and adds a card off the top of the deck
		for (int x = 0; x<handC.cards.Length; x++) {
			
			// Adds a card to player hand with an index that matches the index of the top card of the deck
			handC.AddCard(x, deckC.TopCardIndex(), faceUp);
			
			// Hides the top card of the deck to simulate dealing the card out
			deckC.HideTopCard();
		}
		print (deckC.CardsInDeck ()+1 + " cards left in deck");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
