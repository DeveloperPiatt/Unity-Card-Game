using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DropController : MonoBehaviour, IDropHandler {

	public DragController.Player playerPos = DragController.Player.P1;

	public void OnDrop (PointerEventData eventData) {
		Debug.Log ("Dropped onto "+gameObject.name);

		DragController dc = eventData.pointerDrag.GetComponent<DragController> ();
		if (dc != null) {
			if (playerPos == dc.playerPos) {
				dc.parentToReturnTo = this.transform;
			}
		}
	}
}
