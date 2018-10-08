using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunCountDown : MonoBehaviour
{

	private Text label;
	IEnumerator Start ()
	{
		label = GetComponent<Text>();

		int number = 10;

		while (number > 0)
		{
			yield return new WaitForSeconds(1);
			label.text = number.ToString();
			number--;
		}
		yield return new WaitForSeconds(1);
		label.text = "";
		yield return new WaitForSeconds(1);
		label.text = "GO!";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
