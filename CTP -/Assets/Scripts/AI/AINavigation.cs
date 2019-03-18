using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AINavigation : MonoBehaviour
{

    private NavMeshAgent npc;
    public Vector3 AILocToMove = new Vector3(0,0,0);
    public GameObject AInpc;
    public GameObject moveTo;
    public string[] lines;


    void Awake()
    {
        npc = GetComponent<NavMeshAgent>();
        moveTo = GameObject.FindGameObjectWithTag("GoTo");
    }

	void Start ()
    {
        string path1 = Application.dataPath + "/output1.txt";
        lines = System.IO.File.ReadAllLines(path1); // Will include empty lines. Also when importing the txt remove the numbered lines
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
