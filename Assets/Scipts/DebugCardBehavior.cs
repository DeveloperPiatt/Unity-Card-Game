using UnityEngine;
using System.Collections;

public class DebugCardBehavior : MonoBehaviour {

	CardController cardController;

	int state = 0;
	// Use this for initialization
	void Start () {
		cardController = GetComponent<CardController> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp() {
		state++;

		switch (state) {
		case 1:
			cardController.ShowBackground();
			break;
		case 2:
			cardController.ShowFace();
			break;
		case 3:
			cardController.HideCard();
			break;
		case 4:
			cardController.ShowCardOutline();
			state = 0;
			break;
		}
	}
}
