using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ActionsFulfillment : MonoBehaviour
{
    #region Variables
    public string[,] acts;
    public string[] lines;

    private GameObject rotator;
    private Vector3 prevDist;
    private int choice;

    private NavMeshAgent npc;
    public bool taskComplete = false;
    public bool waitComplete = false;
    public bool wait2 = false;
    public GameObject[] locationMoveToArray;
    private GameObject[] safeHouseArray;
    public Vector3 CurrentGoTo;
    public int currentTaskNum = 0;
    public List<string> items;
    public bool doneOnce = false;
    public bool doneOnce2 = false;
    public bool doneOnce3 = false;
    private MeshRenderer rend;
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
        rotator = GameObject.FindGameObjectWithTag("rotator");
        rend = GetComponent<MeshRenderer>();
	}
	
	void Update ()
    {
        if (waitComplete)
        {
            if (System.IO.File.Exists(Application.dataPath + "/output1.txt")/* && !doneOnce3*/)
            {
                //doneOnce3 = true;
                if (rotator.GetComponent<DayNightCycle>().GetDay() == true)
                {
                    doneOnce2 = false;
                    rend.enabled = true;
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
                else
                {
                    if (!doneOnce2)
                    {
                        doneOnce2 = true;
                        choice = Random.Range(0, safeHouseArray.Length + 1);
                    }
                    npc.destination = safeHouseArray[choice].transform.position;
                    npc.speed = 2.5f;
                    if (Vector3.Distance(this.gameObject.transform.position, safeHouseArray[choice].transform.position) <= 2)
                    {
                        rend.enabled = false;
                    }
                    //npc.isStopped = true;
                }
            }
        }
        
    }

    public void MoveToLocation(Vector3 targetPoint)
    {
        npc.destination = targetPoint;
        CurrentGoTo = targetPoint;
        npc.speed = 1.5f;
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

    #region Tasks
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
        if (wait2 == false)
        {
            switch (item)
            {
                case "ore":
                    {
                        StartCoroutine(Waiting(2.0f));
                        items.Add("ore");
                        Debug.Log("Gathering");
                        break;
                    }
                case "wood":
                    {
                        StartCoroutine(Waiting(2.0f));
                        items.Add("wood");
                        Debug.Log("Gathering");
                        break;
                    }
                case "fish":
                    {
                        StartCoroutine(Waiting(2.0f));
                        items.Add("fish");
                        Debug.Log("Gathering");
                        break;
                    }
                case "water":
                    {
                        StartCoroutine(Waiting(2.0f));
                        items.Add("water");
                        Debug.Log("Gathering");
                        break;
                    }
            }
            //taskComplete = true;
        }

    }

    public void GiveTime(string item)
    {
        if (wait2 == false)
        {
            switch (item)
            {
                case "ore":
                    {
                        StartCoroutine(Waiting(2.0f));
                        items.Remove("ore");
                        Debug.Log("Giving");
                        break;
                    }
                case "wood":
                    {
                        StartCoroutine(Waiting(2.0f));
                        items.Remove("wood");
                        Debug.Log("Giving");
                        break;
                    }
                case "fish":
                    {
                        StartCoroutine(Waiting(2.0f));
                        items.Remove("fish");
                        Debug.Log("Giving");
                        break;
                    }
                case "water":
                    {
                        StartCoroutine(Waiting(2.0f));
                        items.Remove("water");
                        Debug.Log("Giving");
                        break;
                    }
            }
        }
        //taskComplete = true;
    }// removes item character is looking for to list and then finishes taskComplete

    public void IdleTime() // Forces the character to stop moving and tell debug that it is idle
    {
        npc.isStopped = true;
        Debug.Log("Idle Time");
    }
    #endregion

    IEnumerator Waiting(float waitTime)
    {
        wait2 = true;
        yield return new WaitForSeconds(waitTime);
        taskComplete = true;
        wait2 = false;
    }

    IEnumerator WaitforConstruct()
    {
        yield return new WaitForSeconds(3.0f);
        this.gameObject.transform.position = locationMoveToArray[0].transform.position;
        taskComplete = true;
        waitComplete = true;
        acts = this.gameObject.GetComponent<AINavigation>().acts;
        lines = this.gameObject.GetComponent<AINavigation>().lines;
        safeHouseArray = GameObject.FindGameObjectsWithTag("SafeHouse");
        string path1 = Application.dataPath + "/output1.txt";

    }
}
