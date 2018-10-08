using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Word")]
public class Word : ScriptableObject
{
    public UnityEventQueueSystem Solved;

    public string TheWord;

    public void Solving()
    {
        foreach (var VARIABLE in TheWord)
        
        {
            //mark as solved;    
        }
    }

}
