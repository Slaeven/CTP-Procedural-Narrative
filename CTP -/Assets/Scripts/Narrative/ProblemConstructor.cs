using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

// Write all to replace and append to add
public class ProblemConstructor : MonoBehaviour
{
    private int curTextNum = 0;

    public string[] locations = new string[] {"town", "road", "forest", "city", "tundra",
        "blacksmithy", "pond", "abandonedhouse", "mountain" };



    public GameObject[] nodes; // nodes in the center of each tile
    public List<GameObject> nearbyNodes; // stored nearby nodes to current center
    public GameObject[] investNodesArray; // current nodes being investigated for distance
    public GameObject currentCenter;

    private Vector3 distanceX = new Vector3(0, 0, 10);

    void Start()
    {
        nodes = GameObject.FindGameObjectsWithTag("Node");
        GenerateWorld();
        //CreateText();
    }

    void GenerateWorld()
    {
        for (int i = 0; i < nodes.Length; i++)
        {
            nodes[i].tag = "CurrentNode";
            investNodesArray = GameObject.FindGameObjectsWithTag("Node");
            foreach (GameObject node in investNodesArray)
            {
                if (Vector3.Distance(nodes[i].transform.position, node.transform.position) <= 10)
                {
                    nearbyNodes.Add(node);
                }

            }
            nodes[i].tag = "Node";
        }

    }

    void AddBorder()
    {
       // File.AppendAllText(path1, "      (border " + locations[0] + " forest)\n");

        //File.AppendAllText(path1, "      (border " + locations[0] + " forest)\n");
        //File.AppendAllText(path1, "      (border town road)\n");
        //File.AppendAllText(path1, "      (border town hills)\n");
        //File.AppendAllText(path1, "      (border road town)\n");
        //File.AppendAllText(path1, "      (border hills town)\n");
        //File.AppendAllText(path1, "      (border forest town)\n");
        //File.AppendAllText(path1, "      (border hills mountain)\n");
        //File.AppendAllText(path1, "      (border mountain hills)\n");
        //File.AppendAllText(path1, "      (border mountain goblincave)\n");
        //File.AppendAllText(path1, "      (border goblincave mountain)\n");
        //File.AppendAllText(path1, "      (border road city)\n");
        //File.AppendAllText(path1, "      (border city road)\n");
        //File.AppendAllText(path1, "      (border city blacksmithy)\n");
        //File.AppendAllText(path1, "      (border blacksmithy city)\n");
    }

    void CreateText()
    {
        //path
        string path1 = Application.dataPath + "/quest1.txt";
        string path2 = Application.dataPath + "/quest2.txt";
        string path3 = Application.dataPath + "/quest3.txt";
        string path4 = Application.dataPath + "/quest4.txt";
        string path5 = Application.dataPath + "/quest5.txt";
        string path6 = Application.dataPath + "/quest6.txt";
        string path7 = Application.dataPath + "/quest7.txt";
        string path8 = Application.dataPath + "/quest8.txt";
        string path9 = Application.dataPath + "/quest9.txt";


        if (File.Exists(path1))
        {
            File.WriteAllText(path1, "(define (problem goblinking)\n");
            File.AppendAllText(path1, "   (:domain magic-world)\n");
            File.AppendAllText(path1, "   (:objects\n");
            File.AppendAllText(path1, "      npc - character\n");
            File.AppendAllText(path1, "      king blacksmith wizard miner lumberjack - person\n"); // Adjustable for other non AI NPCs
            File.AppendAllText(path1, "      goblin - minor\n"); //Adjustable enemies
            File.AppendAllText(path1, "      gobking - major\n"); // Adjustable Bosses
            File.AppendAllText(path1, "      town forest road city blacksmithy pond mountain tundra abandonedhouse  - location\n"); // 9 Locations
            File.AppendAllText(path1, "      quest sword magic enchantedsword wood water bucket ore pickaxe - element\n");
            File.AppendAllText(path1, "   )\n");


            File.AppendAllText(path1, "   (:init\n");





            File.AppendAllText(path1, "      (at npc town)\n");
            File.AppendAllText(path1, "      (at king city)\n");
            File.AppendAllText(path1, "      (at wizard city)\n");
            File.AppendAllText(path1, "      (at blacksmith city)\n");
            File.AppendAllText(path1, "      (at gobking goblincave)\n");
            File.AppendAllText(path1, "      (at goblin mountain)\n");
            File.AppendAllText(path1, "      (guarded mountain)\n");
            File.AppendAllText(path1, "      (guarded goblincave)\n");
            File.AppendAllText(path1, "   )\n");

            File.AppendAllText(path1, "   (:goal (and (has-complete npc)))\n"); // Objective here
            File.AppendAllText(path1, ")");

        }

    }
	



	void Update ()
    {
	
	}

    public void nextFile()
    {
        curTextNum = curTextNum + 1;
    }
}
