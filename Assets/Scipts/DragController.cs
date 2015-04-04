using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DragController : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler {

	private Vector3 handPosition;

	Transform parentToReturnTo = null;

	public void OnBeginDrag (PointerEventData eventData) {
		Debug.Log ("OnBeginDrag");
		parentToReturnTo = this.transform.parent;
		//this.transform.SetParent (this.transform.parent.parent);
	}

	public void OnDrag (PointerEventData eventData) {
		//Debug.Log ("OnDrag");
		this.transform.position = eventData.position;
	}

	public void OnEndDrag (PointerEventData eventData) {
		Debug.Log ("OnEndDrag");
		//this.transform.SetParent (parentToReturnTo);
		//this.transform.position = handPosition;
	}

	void Start () {
		//handPosition = this.transform.position;
	}

}
