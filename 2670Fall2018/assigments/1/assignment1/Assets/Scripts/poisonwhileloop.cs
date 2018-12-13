using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poisonwhileloop : MonoBehaviour
{
	public int health = 10;

	// Use this for initialization
	void Start () 
	{
		while (health >= 5)
		{
			Debug.Log("Poison hurt you -1 Health");
			health--;
		}
	}
	
	
}
