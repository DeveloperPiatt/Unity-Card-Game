using UnityEngine;
using System.Collections;

public class DeckController : MonoBehaviour {

	public GameObject[] cards;
	public int[] randomFaces;
	
	private int topCard;

	public void Shuffle() {

		// Gets the first card in the deck
		CardController aCard = cards [0].GetComponent<CardController> ();

		// Determining how many different card faces a card can have
		int facesInt = aCard.faces.Length;

		// Generating an array that stores all the cards that should be in the deck
		randomFaces = new int[facesInt*2]; //Deck contains 2 copies of all cards so multiplying by 2

		for (int x = 0; x<randomFaces.Length; x++) {

			// We know there are two copies of each card, so once we've made a set make a new set
			if (x >= facesInt) {
				randomFaces[x] = x - facesInt;
			} else {
				randomFaces[x] = x;
			}
		}

		// Randomizing the values in randomFaces
		// 7 times because why not. Wouldn't be a true shuffle otherwise

		RandomizeIntArray (randomFaces);
		RandomizeIntArray (randomFaces);
		RandomizeIntArray (randomFaces);
		RandomizeIntArray (randomFaces);
		RandomizeIntArray (randomFaces);
		RandomizeIntArray (randomFaces);
		RandomizeIntArray (randomFaces);

		// Assigns each card in the deck an index and puts the card face down
		for (int x = 0; x < cards.Length; x++) {
			CardController thisCard = cards[x].GetComponent<CardController> ();
			thisCard.cardIndex = randomFaces[x];
			thisCard.ShowBackground();
			//thisCard.ShowFace();

			// keeps track where the top card pointer is at
			topCard = x;
		}

		print ("Assigned all "+cards.Length+" cards in deck an index");
	}

	private void RandomizeIntArray(int[] rArray) {
		for (int x = 0; x <rArray.Length; x++) {
			int rI; //random index
			int vA; //value A
			int vB; //value B

			vA = rArray[x];
			rI = Random.Range(0, rArray.Length);

			// avoiding a swap with same index
			if (rI == x) {
				// if the random index is the last index in the array, change it to 0
				// otherwise increment the random index by 1
				if (rI == rArray.Length-1) {
					rI = 0;
				} else {
					rI++;
				}
			}
			vB = rArray[rI];

			// swapping values
			rArray[x] = vB;
			rArray[rI] = vA;
		}
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

	public int CardsInDeck() {
		return topCard;
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
