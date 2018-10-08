﻿using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AiAgent : MonoBehaviour
{
	private NavMeshAgent agent;
	public Transform Destination;
	public Transform GuardPost;
	private Transform finalDestination;
	public FloatData Speed;
	


	void Start()
	{
		
		agent = GetComponent<NavMeshAgent>();
		agent.speed = Speed.Value;
		finalDestination = transform;
		}

	private void OnTriggerEnter(Collider obj)
	{
		if(obj.transform ==Destination)
			finalDestination = Destination;
	}

	private void OnTriggerExit(Collider obj)
	{
		finalDestination = GuardPost;
	}

	private void Update()
	{
		
		
			agent.destination = finalDestination.position;
		
		
	}
}