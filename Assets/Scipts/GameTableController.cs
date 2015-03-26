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

	public void ShuffleDeck(){

		//deck has 8 cards right now
		//find the length of a card's faces array

		deckSize = playerCard.GetComponent<CardController> ().faces.Length;
		print ("Shuffling " + deckSize + " cards!");

	}

	// Use this for initialization
	void Start () {
		//ShuffleDeck ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
