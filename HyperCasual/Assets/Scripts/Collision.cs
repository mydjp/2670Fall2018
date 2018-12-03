using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

	/*void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Player")
		{
			Destroy(col.gameObject);
			print("Shoud destory");
		}
	}*/
	private void OnCollisionEnter(UnityEngine.Collision col)
	{
		if(col.gameObject.name == "Player")
		{
			Destroy(col.gameObject);
			print("Shoud destory");
		}
		
		/*if(col.gameObject.name == "Finish")
		{
			
			print("You Win !!");
		}
		*/
		
	}
}
