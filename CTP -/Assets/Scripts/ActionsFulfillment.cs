using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ActionsFulfillment : MonoBehaviour
{
    public string[,] acts;
    public string[] lines;

    private NavMeshAgent npc;
    public bool taskComplete;
    public bool waitComplete = false;
    public GameObject[] locationMoveToArray;
    public Vector3 CurrentGoTo;
    public int currentTaskNum = 0;


    enum AllLocations
    {
        town,
        road,
        forest,
        city,
        tundra,
        mine,
        pond,
        abandonedhouse,
        mountain
    };


    private void Awake()
    {
        npc = GetComponent<NavMeshAgent>();      
    }

    void Start ()
    {
        StartCoroutine(WaitforConstruct());
	}
	
	void Update ()
    {
        if (waitComplete)
        {
            if (!taskComplete)
            {
                //nextAction = false;
                //for (int i = 0; i < lines.Length; i++)
                //{
                //if (acts[i,0] == "move")
                //{
                //if(acts[i,2] == "town")
                //{
                MoveToLocation(locationMoveToArray[0].transform.position);
                CurrentGoTo = locationMoveToArray[0].transform.position;
                //}
                //if (acts[i, 2] == "road")
                //{
                //    MoveToLocation(movePoints[1]);
                //}
                //if (acts[i, 2] == "forest")
                //{
                //    MoveToLocation(movePoints[2]);
                //}
                //if (acts[i, 2] == "city")
                //{
                //    MoveToLocation(movePoints[3]);
                //}
                //if (acts[i, 2] == "tundra")
                //{
                //    MoveToLocation(movePoints[4]);
                //}
                //if (acts[i, 2] == "mine")
                //{
                //    MoveToLocation(movePoints[5]);
                //}
                //if (acts[i, 2] == "pond")
                //{
                //    MoveToLocation(movePoints[6]);
                //}
                //if (acts[i, 2] == "abandonedhouse")
                //{
                //    MoveToLocation(movePoints[7]);
                //}
                //if (acts[i, 2] == "mountain")
                //{
                //    MoveToLocation(movePoints[8]);
                //}

                //}
                //}

            }
            else
            {
                StartNextTask();
            }
        }
    
    }

    public void MoveToLocation(Vector3 targetPoint)
    {
        npc.destination = targetPoint;
        npc.isStopped = false;
        if (this.gameObject.transform.position == CurrentGoTo)
        {
            taskComplete = true;
        }
    }

    public int StartNextTask()
    {
        if (acts[currentTaskNum, 0] == "move")
        {
            
        }
        else if (acts[currentTaskNum, 0] == "gather-ore")
        {

        }
        else if(acts[currentTaskNum, 0] == "gather-water")
        {

        }
        else if(acts[currentTaskNum, 0] == "gather-fish")
        {

        }
        else if(acts[currentTaskNum, 0] == "gather-wood")
        {

        }
        else if(acts[currentTaskNum, 0] == "give-ore")
        {

        }
        else if(acts[currentTaskNum, 0] == "give-water")
        {

        }
        else if(acts[currentTaskNum, 0] == "give-fish")
        {

        }
        else if(acts[currentTaskNum, 0] == "give-wood")
        {

        }
        currentTaskNum ++;
        return 
    }

    IEnumerator WaitforConstruct()
    {
        yield return new WaitForSeconds(3.0f);
        waitComplete = true;
        acts = this.gameObject.GetComponent<AINavigation>().acts;
        lines = this.gameObject.GetComponent<AINavigation>().lines;
    }
}
