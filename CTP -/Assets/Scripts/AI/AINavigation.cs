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
    public string[,] locs;
    public string[] words;

    void Awake()
    {
        npc = GetComponent<NavMeshAgent>();
        moveTo = GameObject.FindGameObjectWithTag("GoTo");
    }

	void Start ()
    {
        string path1 = Application.dataPath + "/output1.txt";
        lines = System.IO.File.ReadAllLines(path1); // Will include empty lines. Also when importing the txt remove the numbered lines
        StartCoroutine("WaitForSpawn");
        locs = new string[50, 50];
        //words = new string[100];
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

    void Decypher()
    {
        for (int i = 0; i < lines.Length; i++) 
        {
            words = lines[i].Split(" "[0]); // Splits lines into words
        }
        for (int i = 0; i < lines.Length; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (words[j].Equals("move"))
                {
                    string firstLoc = words[j + 2]; // Stores first move location
                    string secondLoc = words[j + 3]; // Stores second move location
                    Storage("move", firstLoc, secondLoc);
                }
            }
        }
       

    }

    void Storage(string action, string firstLoc, string secondLoc) // 2d array storing all movements
    {
        int i = 0;

        locs[i, 0] = firstLoc;
        locs[i, 1] = secondLoc;

        i++;

    }

    IEnumerator WaitForSpawn()
    {
        yield return new WaitForSeconds(2.0f);
        Decypher();

        yield return null;
    }
}
