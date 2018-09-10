﻿
using UnityEngine;

[CreateAssetMenu(fileName =  "NewFloat",menuName = "AR/FloatData")]
public class FloatData : ScriptableObject
{
	public float value;
	
	public virtual float Value
	{
		get { return value;}
	}
		
	
	

}
