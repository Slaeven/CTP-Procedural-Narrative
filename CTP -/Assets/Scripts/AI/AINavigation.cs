﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AINavigation : MonoBehaviour
{

    private NavMeshAgent npc;
    public Vector3 AILocToMove = new Vector3(0,0,0);
    public GameObject AInpc;
    public GameObject moveTo;


    void Awake()
    {
        npc = GetComponent<NavMeshAgent>();
        moveTo = GameObject.FindGameObjectWithTag("GoTo");
    }

	void Start ()
    {
		
	}

    public void MoveToLocation(Vector3 targetPoint)
    {
        npc.destination = targetPoint;
        npc.isStopped = false;
    }

	void Update ()
    {

        MoveToLocation(moveTo.transform.position);
	}
}