﻿
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    public UnityEvent Event;

    private void OnTriggerEnter(Collider obj)
    {
        Event.Invoke();
    }
}
