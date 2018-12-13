using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storeforeachloop : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		string[] level = new string[3];

		level[0] = "You bought the first level";
		level[1] = "You bought the second level";
		level[2] = "You bought the thrid level";

		foreach (string item in level)
		{
			print(item);
		}
		


	}
	
	
}
