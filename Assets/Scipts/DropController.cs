using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DropController : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {



	public void OnDrop (PointerEventData eventData) {
		Debug.Log ("Dropped onto "+gameObject.name);

		DragController dc = eventData.pointerDrag.GetComponent<DragController> ();
		if (dc != null) {
			dc.parentToReturnTo = this.transform;

		}
	}

	public void OnPointerEnter (PointerEventData eventData) {
		Debug.Log("Entered "+gameObject.name);

		if (eventData.pointerDrag == null) {
			return;
		}

		DragController dc = eventData.pointerDrag.GetComponent<DragController> ();
		if (dc != null) {
			dc.placeholderParent = this.transform;
			
		}
	}

	public void OnPointerExit (PointerEventData eventData) {
		Debug.Log("Exited "+gameObject.name);

		if (eventData.pointerDrag == null) {
			return;
		}
		
		DragController dc = eventData.pointerDrag.GetComponent<DragController> ();
		if (dc != null && dc.placeholderParent == this.transform) {
			dc.placeholderParent = dc.parentToReturnTo;
			
		}
	}
}
