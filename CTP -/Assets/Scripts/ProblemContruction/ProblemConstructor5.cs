using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ProblemConstructor5 : MonoBehaviour
{
    #region Enums
    enum QuestType
    {
        Gatherer, // 0
        Messenger,// 1
        Guard,    // 2
        Hero      // 3
    };
    enum CollectablesGatherer
    {
        wood,
        ore,
        water,
        fish
    };
    enum GuardPost
    {
        town,
        city,
        mine,
        road
    };
    enum MessageBox
    {
        town,
        city,
        abandonedhouse,
        mine
    }
    enum HeroDestination
    {
        tundra,
        mountain,
        forest
    }
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

    QuestType questType;
    CollectablesGatherer collectable;
    GuardPost post;
    MessageBox postBox;
    HeroDestination heroDest;
    AllLocations allLocations;
    #endregion
    public int characterType;

    private int curTextNum = 0;

    public GameObject[] nodes; // nodes in the center of each tile
    private GameObject[] investNodesArray; // current nodes being investigated for distance
    private GameObject currentCenter;

    private bool run2 = false;

    private float timer = 0;

    void Start()
    {
        string path1 = Application.dataPath + "/quest6.pddl";
        nodes = GameObject.FindGameObjectsWithTag("Node");
        GenerateProblem();
        File.WriteAllText(path1, "");
    }

    void Update()
    {
        if (timer > 1)
        {
            if (run2 == false)
            {
                run2 = true;
                CreateMainText();
                GenerateWorld();
                FinishText();
            }
        }
        else
        {
            timer += Time.deltaTime;
        }

    }

    void GenerateProblem()
    {
        string path1 = Application.dataPath + "/quest6.pddl";
        questType = (QuestType)(Random.Range(0, 4));
        allLocations = (AllLocations)(Random.Range(0, 8));

        switch (questType)
        {
            case QuestType.Gatherer:
                {
                    collectable = (CollectablesGatherer)(Random.Range(0, 4));
                    File.AppendAllText(path1, "  (:goal(and (has-" + collectable + " npc)))\n");
                    break;
                }
            case QuestType.Messenger:
                {
                    postBox = (MessageBox)(Random.Range(0, 4));
                    File.AppendAllText(path1, "  (:goal(and (at npc " + postBox + ")))\n");
                    break;
                }
            case QuestType.Guard:
                {
                    post = (GuardPost)(Random.Range(0, 4));
                    File.AppendAllText(path1, "  (:goal(and (at npc " + post + ")))\n");
                    break;
                }
            case QuestType.Hero:
                {
                    heroDest = (HeroDestination)(Random.Range(0, 4));
                    File.AppendAllText(path1, "  (:goal(and (at npc " + heroDest + ")))\n");
                    break;
                }
        }
    }

    void GenerateWorld()
    {
        for (int i = 0; i < nodes.Length; i++)
        {
            nodes[i].tag = "CurrentNode";
            investNodesArray = GameObject.FindGameObjectsWithTag("Node");
            foreach (GameObject neighbourNode in investNodesArray)
            {
                if (Vector3.Distance(nodes[i].transform.position, neighbourNode.transform.position) == 10)
                {
                    AddBorder(nodes[i].transform.parent.name, neighbourNode.transform.parent.name); // pass name of current nodes parent and name of neighbours parent
                }
            }
            nodes[i].tag = "Node";
        }

    }

    void AddBorder(string currentNodeName, string neighbourParentName)
    {
        string path1 = Application.dataPath + "/quest6.pddl";

        File.AppendAllText(path1, "      (border " + currentNodeName + " " + neighbourParentName + ")\n");
    }

    void CreateMainText()
    {
        string path1 = Application.dataPath + "/quest6.pddl";

        File.WriteAllText(path1, "(define (problem mk5)\n");
        File.AppendAllText(path1, "   (:domain magic-world)\n");
        File.AppendAllText(path1, "   (:objects\n");
        File.AppendAllText(path1, "      npc - character\n");
        File.AppendAllText(path1, "      kingperson - king\n"); // Adjustable for other non AI NPCs
        File.AppendAllText(path1, "      blacksmithperson - blacksmith\n");
        File.AppendAllText(path1, "      shopkeepperson - shopkeep\n");
        File.AppendAllText(path1, "      minerperson - miner\n");
        File.AppendAllText(path1, "      lumberjackperson - lumberjack\n");
        File.AppendAllText(path1, "      fisherperson - fisher\n");
        File.AppendAllText(path1, "      goblin - minor\n"); //Adjustable enemies
        File.AppendAllText(path1, "      gobking - major\n"); // Adjustable Bosses
        File.AppendAllText(path1, "      questobject - quest\n");
        File.AppendAllText(path1, "      swordobject - sword\n");
        File.AppendAllText(path1, "      woodobject - wood\n");
        File.AppendAllText(path1, "      waterobject - water\n");
        File.AppendAllText(path1, "      bucketobject - bucket\n");
        File.AppendAllText(path1, "      oreobject - ore\n");
        File.AppendAllText(path1, "      pickaxeobject - pickaxe\n");
        File.AppendAllText(path1, "      fishobject - fish\n");
        File.AppendAllText(path1, "      town forest road city mine pond mountain tundra abandonedhouse  - location\n"); // 9 Locations
        File.AppendAllText(path1, "   )\n");
        File.AppendAllText(path1, "   (:init\n");
    }

    void FinishText()
    {
        string path1 = Application.dataPath + "/quest6.pddl";

        File.AppendAllText(path1, "      (at kingperson city)\n");
        File.AppendAllText(path1, "      (at blacksmithperson mine)\n");
        File.AppendAllText(path1, "      (at minerperson mine)\n");
        File.AppendAllText(path1, "      (at lumberjackperson town)\n");
        File.AppendAllText(path1, "      (at shopkeepperson town)\n");
        File.AppendAllText(path1, "      (at fisherperson pond)\n");
        File.AppendAllText(path1, "      (at fishobject pond)\n");
        File.AppendAllText(path1, "      (at woodobject forest)\n");
        File.AppendAllText(path1, "      (at oreobject mine)\n");
        File.AppendAllText(path1, "      (at waterobject pond)\n");
        File.AppendAllText(path1, "      (at bucketobject town)\n");
        File.AppendAllText(path1, "      (at swordobject town)\n");
        File.AppendAllText(path1, "      (at pickaxeobject mine)\n");
        File.AppendAllText(path1, "      (at npc " + allLocations + ")\n");

        File.AppendAllText(path1, "   )\n");
        GenerateProblem(); // Generate a problem for a NPC to fulfill
        File.AppendAllText(path1, ")");

    }

    public void nextFile()
    {
        curTextNum = curTextNum + 1;
    }

}
