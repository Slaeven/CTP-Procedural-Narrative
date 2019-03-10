using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ProblemConstructor : MonoBehaviour
{
    private int curTextNum = 0;

    //public string[] locations = new string[] {"town", "road", "forest", "city", "tundra",
    //    "blacksmithy", "pond", "abandonedhouse", "mountain" };

    public GameObject[] nodes; // nodes in the center of each tile
    public GameObject[] investNodesArray; // current nodes being investigated for distance
    public GameObject currentCenter;
    public bool run1 = false;
    public bool run2 = false;

    private float timer = 0;

    void Start()
    {
        string path1 = Application.dataPath + "/quest1.pddl";
        nodes = GameObject.FindGameObjectsWithTag("Node");
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
        string path1 = Application.dataPath + "/quest1.pddl";
        string path2 = Application.dataPath + "/quest2.pddl";
        string path3 = Application.dataPath + "/quest3.pddl";
        string path4 = Application.dataPath + "/quest4.pddl";
        string path5 = Application.dataPath + "/quest5.pddl";
        string path6 = Application.dataPath + "/quest6.pddl";
        string path7 = Application.dataPath + "/quest7.pddl";
        string path8 = Application.dataPath + "/quest8.pddl";
        string path9 = Application.dataPath + "/quest9.pddl";

        File.AppendAllText(path1, "      (border " + currentNodeName + " " + neighbourParentName + ")\n");
    }


    void CreateMainText()
    {
        string path1 = Application.dataPath + "/quest1.pddl";
        string path2 = Application.dataPath + "/quest2.pddl";
        string path3 = Application.dataPath + "/quest3.pddl";
        string path4 = Application.dataPath + "/quest4.pddl";
        string path5 = Application.dataPath + "/quest5.pddl";
        string path6 = Application.dataPath + "/quest6.pddl";
        string path7 = Application.dataPath + "/quest7.pddl";
        string path8 = Application.dataPath + "/quest8.pddl";
        string path9 = Application.dataPath + "/quest9.pddl";


            File.WriteAllText(path1, "(define (problem goblinking)\n");
            File.AppendAllText(path1, "   (:domain magic-world)\n");
            File.AppendAllText(path1, "   (:objects\n");
            File.AppendAllText(path1, "      npc - player\n");
            File.AppendAllText(path1, "      king blacksmith shopkeep miner lumberjack fisher - person\n"); // Adjustable for other non AI NPCs
            File.AppendAllText(path1, "      goblin - minor\n"); //Adjustable enemies
            File.AppendAllText(path1, "      gobking - major\n"); // Adjustable Bosses
            File.AppendAllText(path1, "      town forest road city blacksmithy pond mountain tundra abandonedhouse  - location\n"); // 9 Locations
            File.AppendAllText(path1, "      quest sword magic enchantedsword wood water bucket ore pickaxe - object\n");
            File.AppendAllText(path1, "   )\n");
            File.AppendAllText(path1, "   (:init\n");
    }

    void FinishText()
    {
        string path1 = Application.dataPath + "/quest1.pddl";
        string path2 = Application.dataPath + "/quest2.pddl";
        string path3 = Application.dataPath + "/quest3.pddl";
        string path4 = Application.dataPath + "/quest4.pddl";
        string path5 = Application.dataPath + "/quest5.pddl";
        string path6 = Application.dataPath + "/quest6.pddl";
        string path7 = Application.dataPath + "/quest7.pddl";
        string path8 = Application.dataPath + "/quest8.pddl";
        string path9 = Application.dataPath + "/quest9.pddl";

        File.AppendAllText(path1, "      (at king city)\n");
        File.AppendAllText(path1, "      (at blacksmith blacksmithy)\n");
        File.AppendAllText(path1, "      (at miner blacksmithy)\n");
        File.AppendAllText(path1, "      (at lumberjack town)\n");
        File.AppendAllText(path1, "      (at shopkeep town)\n");
        File.AppendAllText(path1, "      (at fisher pond)\n");
        File.AppendAllText(path1, "   )\n");
        File.AppendAllText(path1, "  (:goal(and (has-complete npc)))\n");
        File.AppendAllText(path1, ")");

    }

    public void nextFile()
    {
        curTextNum = curTextNum + 1;
    }

}
