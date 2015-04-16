using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragController : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler {

	private Vector3 handPosition;

	public Transform parentToReturnTo = null;
	public Transform placeholderParent = null;
	public bool canDrag = true;

	GameObject placeholder = null;

	public void OnBeginDrag (PointerEventData eventData) {

		Debug.Log ("OnBeginDrag");
		
		parentToReturnTo = this.transform.parent;
		
		placeholder = new GameObject ();
		placeholder.transform.SetParent (this.transform.parent);
		
		LayoutElement le = placeholder.AddComponent<LayoutElement>();
		le.preferredHeight = this.GetComponent<LayoutElement> ().preferredHeight;
		le.preferredWidth = this.GetComponent<LayoutElement> ().preferredWidth;
		le.flexibleHeight = 0;
		le.flexibleWidth = 0;
		
		placeholder.transform.SetSiblingIndex (this.transform.GetSiblingIndex ());
		
		placeholderParent = parentToReturnTo;
		
		this.transform.SetParent (this.transform.parent.parent);
		GetComponent<CanvasGroup>().blocksRaycasts = false;

	}

	public void OnDrag (PointerEventData eventData) {
		//Debug.Log ("OnDrag");
		this.transform.position = eventData.position;
		
		if (placeholder.transform.parent != placeholderParent) {
			placeholder.transform.SetParent(placeholderParent);
		}
		
		int newSiblingIndex = placeholderParent.childCount;
		
		for (int x = 0; x < placeholderParent.childCount; x++) {
			if (this.transform.position.x < placeholderParent.GetChild(x).position.x ) {
				
				newSiblingIndex = x;
				
				if (placeholder.transform.GetSiblingIndex() < newSiblingIndex) {
					newSiblingIndex--;
				}
				
				break;
			}
		}
		
		placeholder.transform.SetSiblingIndex(newSiblingIndex);


			

	}

	public void OnEndDrag (PointerEventData eventData) {

		Debug.Log ("OnEndDrag");
		this.transform.SetParent (parentToReturnTo);
		this.transform.SetSiblingIndex (placeholder.transform.GetSiblingIndex ());
		GetComponent<CanvasGroup> ().blocksRaycasts = true;
		Destroy (placeholder);


		// stops this card from being dragged someplace else
		this.enabled = canDrag;
			


	}

	void Start () {
		//handPosition = this.transform.position;
	}

}
