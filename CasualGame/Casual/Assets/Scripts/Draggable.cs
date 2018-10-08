using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{

	private Vector3 currentPostion;
	private Vector3 newPosistion;
	private Camera  cam;

	 void Start()
	{
		cam = Camera.main;
		
	}

	private void OnMouseDown()
	{
		currentPostion = transform.position - cam.ScreenToWorldPoint(Input.mousePosition);
	}


	// Update is called once per frame
	void OnMouseDrag ()
	{
		newPosistion = currentPostion + cam.ScreenToWorldPoint(Input.mousePosition);
		newPosistion.z = 0;
		transform.position = newPosistion;
	}
}
