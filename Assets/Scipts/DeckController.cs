using UnityEngine;
using System.Collections;

public class DeckController : MonoBehaviour {

	public GameObject[] cards;
	public int[] randomFaces;
	
	private int topCard;

	public void Shuffle() {

		CardController aCard = cards [0].GetComponent<CardController> ();
		int facesInt = aCard.faces.Length;
		randomFaces = new int[facesInt];

		for (int x = 0; x<facesInt; x++) {
			randomFaces[x] = x;
		}

		for (int x = 0; x<cards.Length; x++) {
			CardController thisCard = cards[x].GetComponent<CardController> ();
			thisCard.cardIndex = randomFaces[x];
			thisCard.ShowBackground();

			topCard = x;
		}

		print ("Assigned all cards in deck an index");
	}

	public void HideTopCard() {

		if (topCard > 0) {
			// still cards left to give out!
			CardController tCard = cards [topCard].GetComponent<CardController> ();
			tCard.HideCard ();
			topCard--;
		}

	}

	public int TopCardIndex() {
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
