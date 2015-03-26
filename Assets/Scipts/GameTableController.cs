using UnityEngine;
using System.Collections;

public class GameTableController : MonoBehaviour {

	//TODO: Build a deck of cards
	//TODO: Deal out 5 cards to the player
	//TODO: Take the 5 cards out of the deck
	//TODO: Display the 5 cards for the player

	public GameObject playerHand;
	public GameObject playerCard;
	public GameObject gameDeck;

	private int deckSize;
	private CardController[] deck;

	// Use this for initialization
	void Start () {
		gameDeck.GetComponent<DeckController> ().Shuffle ();
		DealCardsToPlayer ();
	}

	void DealCardsToPlayer() {
		DeckController deckC = gameDeck.GetComponent<DeckController> ();
		HandController handC = playerHand.GetComponent<HandController> ();

		for (int x = 0; x<handC.cards.Length; x++) {
			handC.AddCard(x, deckC.TopCardIndex(), true);
			deckC.HideTopCard();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
