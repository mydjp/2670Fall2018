using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public float moveDistance = 10;

	public int aCount = 0;
	public int dCount = 1;

	void Update () {
		
		Vector3 pos = transform.position;

		if(Input.GetKeyDown("a") && aCount == 0)
		{
			aCount = 1;
			pos.x -= moveDistance;
			pos.z += moveDistance;
			dCount = 0;
			
		}

		if(Input.GetKeyDown("a") && aCount == 1)
		{
			aCount = 1;
			pos.z += moveDistance;
			dCount = 0;

			
		}




		if(Input.GetKeyDown("d") && dCount == 0)
		{
			dCount = 1;
			pos.x += moveDistance;
			pos.z += moveDistance;
			aCount = 0;
		}

		if(Input.GetKeyDown("d") && dCount == 1)
		{
			dCount = 1;
			pos.z += moveDistance;
			aCount = 0;
		}
		
		transform.position = pos;

	}
}
