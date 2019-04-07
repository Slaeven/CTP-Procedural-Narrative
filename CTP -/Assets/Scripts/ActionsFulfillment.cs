using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ActionsFulfillment : MonoBehaviour
{
    #region Variables
    public string[,] acts;
    public string[] lines;

    private NavMeshAgent npc;
    public bool taskComplete = false;
    public bool waitComplete = false;
    public GameObject[] locationMoveToArray;
    public Vector3 CurrentGoTo;
    public int currentTaskNum = 0;
    public List<string> items;
    public bool doneOnce = false;
    #endregion

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
    enum CurrentTask
    {
        Idle,
        Moving,
        Gathering,
        Giving,
        Fighting   
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
            if (!taskComplete)  //if task is in progress wait till complete
            {
                MaintainTask();
            }
            else if (taskComplete) // If task is complete start the next on the list
            {
                taskComplete = false;
                currentTaskNum++;
            }
        }
        
        
    }

    public void MoveToLocation(Vector3 targetPoint)
    {
        npc.destination = targetPoint;
        CurrentGoTo = targetPoint;
        npc.isStopped = false;
        if (Vector3.Distance(this.gameObject.transform.position, CurrentGoTo) <= 2)
        {
            taskComplete = true;
        }
    }

    public void MaintainTask()
    {
        switch (acts[currentTaskNum, 0])
        {
            case "move":
                {
                    MoveTime();
                    break;
                }
            case "gather-ore":
                {
                    GatherTime("ore");
                    break;
                }
            case "gather-water":
                {
                    GatherTime("water");
                    break;
                }
            case "gather-fish":
                {
                    GatherTime("fish");
                    break;
                }
            case "gather-wood":
                {
                    GatherTime("wood");
                    break;
                }
            case "give-ore":
                {
                    GiveTime("ore");
                    break;
                }
            case "give-water":
                {
                    GiveTime("water");
                    break;
                }
            case "give-fish":
                {
                    GiveTime("fish");
                    break;
                }
            case "give-wood":
                {
                    GiveTime("wood");
                    break;
                }
            case "":
                {
                    IdleTime();
                    break;
                }
        }
    } // Checks task list and oes to appropriate function call

    public void MoveTime()
    {
        switch(acts[currentTaskNum,2])
        {
            case "town":
                {
                    MoveToLocation(locationMoveToArray[0].transform.position);
                    break;
                }
            case "road":
                {
                    MoveToLocation(locationMoveToArray[1].transform.position);
                    break;
                }
            case "forest":
                {
                    MoveToLocation(locationMoveToArray[2].transform.position);
                    break;
                }
            case "city":
                {
                    MoveToLocation(locationMoveToArray[3].transform.position);
                    break;
                }
            case "tundra":
                {
                    MoveToLocation(locationMoveToArray[4].transform.position);
                    break;
                }
            case "mine":
                {
                    MoveToLocation(locationMoveToArray[5].transform.position);
                    break;
                }
            case "pond":
                {
                    MoveToLocation(locationMoveToArray[6].transform.position);
                    break;
                }
            case "abandonedhouse":
                {
                    MoveToLocation(locationMoveToArray[7].transform.position);
                    break;
                }
            case "mountain":
                {
                    MoveToLocation(locationMoveToArray[8].transform.position);
                    break;
                }
        }
    }

    public void GatherTime(string item) // adds item character is looking for to list and then finishes taskComplete
    {
        switch (item)
        {
            case "ore":
                {
                    items.Add("ore");
                    break;
                }
            case "wood":
                {
                    items.Add("wood");
                    break;
                }
            case "fish":
                {
                    items.Add("fish");
                    break;
                }
            case "water":
                {
                    items.Add("water");
                    break;
                }
        }
        taskComplete = true;
    }

    public void GiveTime(string item)
    {
        switch(item)
        {
            case "ore":
                {
                    items.Remove("ore");
                    break;
                }
            case "wood":
                {
                    items.Remove("wood");
                    break;
                }
            case "fish":
                {
                    items.Remove("fish");
                    break;
                }
            case "water":
                {
                    items.Remove("water");
                    break;
                }
        }
        taskComplete = true;
    }// removes item character is looking for to list and then finishes taskComplete

    public void IdleTime() // Forces the character to stop moving and tell debug that it is idle
    {
        npc.isStopped = true;
        Debug.Log("Idle Time");
    }

    IEnumerator WaitforConstruct()
    {
        yield return new WaitForSeconds(3.0f);
        this.gameObject.transform.position = locationMoveToArray[0].transform.position;
        taskComplete = true;
        waitComplete = true;
        acts = this.gameObject.GetComponent<AINavigation>().acts;
        lines = this.gameObject.GetComponent<AINavigation>().lines;

    }
}
