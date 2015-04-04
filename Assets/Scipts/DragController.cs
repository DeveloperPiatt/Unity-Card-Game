using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DragController : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler {

	private Vector3 handPosition;

	public enum Player{P1, P2, P3, P4};
	public Player playerPos = Player.P1;

	public Transform parentToReturnTo = null;

	public void OnBeginDrag (PointerEventData eventData) {
		Debug.Log ("OnBeginDrag");
		parentToReturnTo = this.transform.parent;
		this.transform.SetParent (this.transform.parent.parent);

		GetComponent<CanvasGroup>().blocksRaycasts = false;
	}

	public void OnDrag (PointerEventData eventData) {
		//Debug.Log ("OnDrag");
		this.transform.position = eventData.position;
	}

	public void OnEndDrag (PointerEventData eventData) {
		Debug.Log ("OnEndDrag");
		this.transform.SetParent (parentToReturnTo);
		GetComponent<CanvasGroup> ().blocksRaycasts = true;
		//this.transform.position = handPosition;
	}

	void Start () {
		//handPosition = this.transform.position;
	}

}
