using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CardController : MonoBehaviour {

	public HandController.PlayerNumber playerNum;

	public Text topValue;
	public Text rightValue;
	public Text downValue;
	public Text leftValue;

	public Color32 p1Color;
	public Color32 p2Color;

	void setPlayer() {
		HandController cardHand = this.transform.parent.parent.GetComponent<HandController> ();
		playerNum = cardHand.playerNum;

		p1Color = new Color32 (0, 221, 255, 255);
		p2Color = new Color32 (255, 149, 0, 255);

		//setting background color to match player
		if (playerNum == HandController.PlayerNumber.PLAYER1) {
			this.GetComponent<Image> ().color = p1Color;
		} else if (playerNum == HandController.PlayerNumber.PLAYER2) {
			this.GetComponent<Image> ().color = p2Color;
		}


	}

	public void togglePlayer () {

		//checks current card's player value and swaps it. Also swaps color to let us know which player owns card

		if (playerNum == HandController.PlayerNumber.PLAYER1) {
			playerNum = HandController.PlayerNumber.PLAYER2;
			this.GetComponent<Image> ().color = p2Color;
		} else if (playerNum == HandController.PlayerNumber.PLAYER2) {
			playerNum = HandController.PlayerNumber.PLAYER1;
			this.GetComponent<Image> ().color = p1Color;
		}
	}


	void setRandomValues() {

		topValue.text = Random.Range (1, 9).ToString ();
		rightValue.text = Random.Range (1, 9).ToString ();
		downValue.text = Random.Range (1, 9).ToString ();
		leftValue.text = Random.Range (1, 9).ToString ();

	}

	// Use this for initialization
	void Start () {

		setPlayer ();
		setRandomValues ();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
