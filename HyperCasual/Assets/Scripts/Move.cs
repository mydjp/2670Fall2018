using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public float moveDistance = 10;

	public int aCount = 0;
	public int dCount = 1;

	void Update () {
		
		Vector3 pos = transform.position;

		if(Input.GetKeyDown("a"))
		{
			switch(aCount)
			{
				case 0:
					aCount = 1;
					pos.x -= moveDistance;
					pos.z += moveDistance;
					dCount = 0;
					
					break;

				case 1: 
					aCount = 1;
					pos.z += moveDistance;
					dCount = 0;
					
					break;

			}
		}

		if(Input.GetKeyDown("s"))
		{
			switch(dCount)
			{
				case 0:
					dCount = 1;
					pos.x += moveDistance;
					pos.z += moveDistance;
					aCount = 0;
					
					break;

				case 1: 
					dCount = 1;
					pos.z += moveDistance;
					aCount = 0;
					
					break;

			}
		}
		
		transform.position = pos;

	}
}
