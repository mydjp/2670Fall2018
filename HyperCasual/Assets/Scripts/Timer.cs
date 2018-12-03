using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
	
	public UnityEvent OnCount;
	public IntData timeleft;
	public float Seconds = 1.0f;
	public Text text;
	
	IEnumerator Start () 
	{
		while (timeleft.Value>=0)
		{
			OnCount.Invoke();
			print(timeleft.Value);
			yield return new WaitForSeconds(Seconds);
			timeleft.Value--;
		}
		
	}
	

}
