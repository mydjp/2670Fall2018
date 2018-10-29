using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Timer : MonoBehaviour
{
	
	public UnityEvent OnCount;
	public float Seconds=1;
	
	IEnumerator Start () 
	{
		while (true)
		{
			OnCount.Invoke();
			yield return new WaitForSeconds(Seconds);
		}
		
	}
	

}
