using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DropController : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

	public Transform topDropZone;
	public Transform rightDropZone;
	public Transform bottomDropZone;
	public Transform leftDropZone;

	public void OnDrop (PointerEventData eventData) {

		//Debug.Log ("Dropped onto "+gameObject.name);

		DragController dc = eventData.pointerDrag.GetComponent<DragController> ();
		if (dc != null) {
			dc.parentToReturnTo = this.transform;

			// tells the drag controller that it needs to turn itself off
			dc.canDrag = false;

			// turns off this drop zone so no further cards can be placed
			this.enabled = false;
		}

		CardController myCard = eventData.pointerDrag.GetComponent<CardController>();

		//following code will check to see if adjacent drop zones have any cards in them
		//if cards exist, evaluate which card would win in combat and flip the defending card if it loses

		if (topDropZone != null) {
			//Debug.Log("Need to check top");

			if (topDropZone.childCount > 0) {

				CardController cardToBattle = topDropZone.GetChild(0).GetComponent<CardController>();

				//if my card has a higher value than target card AND the two cards don't belong to the same player
				if (int.Parse(myCard.topValue.text) > int.Parse(cardToBattle.downValue.text) && myCard.playerNum != cardToBattle.playerNum) {
					cardToBattle.togglePlayer();
				}

				Debug.Log("Battle top: "+int.Parse(myCard.topValue.text)+" <-> "+int.Parse(cardToBattle.downValue.text));
			}
		}

		if (rightDropZone != null) {
			//Debug.Log("Need to check right");

			if (rightDropZone.childCount > 0) {
				
				CardController cardToBattle = rightDropZone.GetChild(0).GetComponent<CardController>();

				//if my card has a higher value than target card AND the two cards don't belong to the same player
				if (int.Parse(myCard.rightValue.text) > int.Parse(cardToBattle.leftValue.text) && myCard.playerNum != cardToBattle.playerNum) {
					cardToBattle.togglePlayer();
				}
				
				Debug.Log("Battle right: "+int.Parse(myCard.rightValue.text)+" <-> "+int.Parse(cardToBattle.leftValue.text));
			}
		}

		if (bottomDropZone != null) {
			//Debug.Log("Need to check bottom");

			if (bottomDropZone.childCount > 0) {

				CardController cardToBattle = bottomDropZone.GetChild(0).GetComponent<CardController>();

				//if my card has a higher value than target card AND the two cards don't belong to the same player
				if (int.Parse(myCard.downValue.text) > int.Parse(cardToBattle.topValue.text) && myCard.playerNum != cardToBattle.playerNum) {
					cardToBattle.togglePlayer();
				}

				Debug.Log("Battle bottom: "+int.Parse(myCard.downValue.text)+" <-> "+int.Parse(cardToBattle.topValue.text));
			}
		}

		if (leftDropZone != null) {
			//Debug.Log("Need to check left");

			if (leftDropZone.childCount > 0) {
				
				CardController cardToBattle = leftDropZone.GetChild(0).GetComponent<CardController>();

				//if my card has a higher value than target card AND the two cards don't belong to the same player
				if (int.Parse(myCard.leftValue.text) > int.Parse(cardToBattle.rightValue.text) && myCard.playerNum != cardToBattle.playerNum) {
					cardToBattle.togglePlayer();
				}
				
				Debug.Log("Battle left: "+int.Parse(myCard.leftValue.text)+" <-> "+int.Parse(cardToBattle.rightValue.text));
			}
		}

	}

	public void OnPointerEnter (PointerEventData eventData) {
		//Debug.Log("Entered "+gameObject.name);

		if (eventData.pointerDrag == null) {
			return;
		}

		DragController dc = eventData.pointerDrag.GetComponent<DragController> ();
		if (dc != null) {
			dc.placeholderParent = this.transform;
			
		}
	}

	public void OnPointerExit (PointerEventData eventData) {
		//Debug.Log("Exited "+gameObject.name);

		if (eventData.pointerDrag == null) {
			return;
		}
		
		DragController dc = eventData.pointerDrag.GetComponent<DragController> ();
		if (dc != null && dc.placeholderParent == this.transform) {
			dc.placeholderParent = dc.parentToReturnTo;
			
		}
	}
}
