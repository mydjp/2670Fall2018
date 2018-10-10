using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{

	private Vector3 offsetPostion;
	private Vector3 newPosistion;
	private Camera cam;

	public bool CanDrag;



	private void Start()
	{
		cam = Camera.main;

	}

	public IEnumerator OnMouseDown()
	{
		offsetPostion = transform.position - cam.ScreenToWorldPoint(Input.mousePosition);
		yield return new WaitForFixedUpdate();
		CanDrag = true;
		while (CanDrag)
		{
			yield return new WaitForFixedUpdate();
			newPosistion = cam.ScreenToWorldPoint(Input.mousePosition) + offsetPostion;
			transform.position = newPosistion;
		}
	}

	private void OnMouseUp()
	{
		CanDrag = false;
	}
}



