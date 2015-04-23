using UnityEngine;
using System.Collections;

public class TurnController : MonoBehaviour {

	public HandController.PlayerNumber playersTurn;

	public void nextTurn() {
		if (playersTurn == HandController.PlayerNumber.PLAYER1) {
			playersTurn = HandController.PlayerNumber.PLAYER2;
		} else {
			playersTurn = HandController.PlayerNumber.PLAYER1;
		}
	}

	// Use this for initialization
	void Start () {
		playersTurn = HandController.PlayerNumber.PLAYER1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
