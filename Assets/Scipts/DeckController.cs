using UnityEngine;
using System.Collections;

public class DeckController : MonoBehaviour {

	public GameObject[] cards;

	public void Shuffle() {

		CardController aCard = cards [0].GetComponent<CardController> ();
		int facesInt = aCard.faces.Length;

		int[] randomFaces;
		randomFaces = new int[facesInt];

		for (int x = 0; x<facesInt; x++) {
			randomFaces[x] = x;
		}

		for (int x = 0; x<cards.Length; x++) {
			CardController thisCard = cards[x].GetComponent<CardController> ();
			thisCard.cardIndex = randomFaces[x];
			thisCard.ShowFace();

		}
		print ("Assigned all cards in deck an index");

	}

	// Use this for initialization
	void Start () {
		Shuffle ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
