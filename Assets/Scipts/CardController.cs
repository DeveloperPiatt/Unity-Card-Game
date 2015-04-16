using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CardController : MonoBehaviour {

	public HandController.PlayerNumber playerNum;

	public Text topValue;
	public Text rightValue;
	public Text downValue;
	public Text leftValue;

	void setPlayer() {
		HandController cardHand = this.transform.parent.parent.GetComponent<HandController> ();
		playerNum = cardHand.playerNum;

		//setting background color to match player
		//this.GetComponent<Image> ().color = new Color32 (0, 0, 0);
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
