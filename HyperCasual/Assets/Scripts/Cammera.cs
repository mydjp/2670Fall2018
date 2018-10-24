using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cammera : MonoBehaviour
{

	public float moveDistance = 10;


	void Update()
	{

		Vector3 pos = transform.position;

		if (Input.GetKeyDown("a"))
		{

			pos.z += moveDistance;

		}




		if (Input.GetKeyDown("d"))
		{

			pos.z += moveDistance;

			transform.position = pos;

		}
	}
}
