using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CardController : MonoBehaviour {

	public HandController.PlayerNumber playerNum;

	void setPlayer() {
		HandController cardHand = this.transform.parent.parent.GetComponent<HandController> ();
		playerNum = cardHand.playerNum;
	}

	// Use this for initialization
	void Start () {
		setPlayer ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
