using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	public Transform blueScore;
	public Transform redScore;

	public void blueCapture () {
		addBluePoint ();
		removeRedPoint ();
	}

	public void redCapture () {
		addRedPoint ();
		removeBluePoint ();
	}

	public void addBluePoint () {
		Text bText = blueScore.GetComponent<Text> ();
		
		int bScore = int.Parse (bText.text);
		bScore++;
		bText.text = bScore.ToString ();
	}

	public void addRedPoint () {
		Text rText = redScore.GetComponent<Text> ();
		
		int rScore = int.Parse (rText.text);
		rScore++;
		rText.text = rScore.ToString ();
	}

	void removeBluePoint() {
		Text bText = blueScore.GetComponent<Text> ();
		
		int bScore = int.Parse (bText.text);
		bScore--;
		bText.text = bScore.ToString ();
	}

	void  removeRedPoint() {
		Text rText = redScore.GetComponent<Text> ();
		
		int rScore = int.Parse (rText.text);
		rScore--;
		rText.text = rScore.ToString ();
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
