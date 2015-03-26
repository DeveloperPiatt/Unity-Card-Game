using UnityEngine;
using System.Collections;

public class HandController : MonoBehaviour {

	public GameObject[] cards;
	public int clientID;

	// Use this for initialization

	public void AddCard (int cardId, int cardIndex, bool showFaceUp){
		CardController cardController = cards [cardId].GetComponent<CardController> ();
		cardController.cardIndex = cardIndex;
		if (showFaceUp) {
			cardController.ShowFace ();
		} else {
			cardController.ShowBackground();
		}
	}	

	public void Reset() {

		CardController firstCardController = cards [0].GetComponent<CardController> ();
		firstCardController.cardIndex = 0;
		firstCardController.ShowCardOutline();

		for (int x = 1; x < cards.Length; x++) {
			CardController cardController = cards[x].GetComponent<CardController>();
			cardController.HideCard();
		}
	}

	void Start () {
	
		Reset ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
