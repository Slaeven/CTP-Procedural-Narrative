using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AINavigation4 : MonoBehaviour
{
    public string[] lines;
    public string[] words;
    public string[,] acts;
    public bool doneOnce = false;

    void Start ()
    {

    }

	void Update ()
    {
        if (System.IO.File.Exists(Application.dataPath + "/output5.txt") && !doneOnce)
        {
            doneOnce = true;
            string path1 = Application.dataPath + "/output5.txt";
            lines = System.IO.File.ReadAllLines(path1); // Will include empty lines. Also when importing the txt remove the numbered lines and gaps
            StartCoroutine(WaitForSpawn());
            acts = new string[50, 4];
        }
	}

    void Decypher()
    {
        for (int i = 0; i < lines.Length; i++)
        {
            words = lines[i].Split(" "[0]); // Splits lines into words

            switch (words[0])
            {
                case "move":
                    {
                        string firstLoc = words[0 + 2]; // Stores first move location
                        string secondLoc = words[0 + 3]; // Stores second move location
                        StorageMove("move", firstLoc, secondLoc, i);
                        break;
                    }
                case "gather-ore":
                    {
                        string obj = words[3];
                        StorageGather("gather-ore", obj, i);
                        break;
                    }
                case "gather-water":
                    {
                        string obj = words[3];
                        StorageGather("gather-water", obj, i);
                        break;
                    }
                case "gather-fish":
                    {
                        string obj = words[3];
                        StorageGather("gather-fish", obj, i);
                        break;
                    }
                case "gather-wood":
                    {
                        string obj = words[3];
                        StorageGather("gather-wood", obj, i);
                        break;
                    }
                case "give-ore":
                    {
                        string obj = words[3];
                        StorageGather("give-ore", obj, i);
                        break;
                    }
                case "give-water":
                    {
                        string obj = words[3];
                        StorageGather("give-water", obj, i);
                        break;
                    }
                case "give-fish":
                    {
                        string obj = words[3];
                        StorageGather("give-fish", obj, i);

                        break;
                    }
                case "give-wood":
                    {
                        string obj = words[3];
                        StorageGather("give-wood", obj, i);
                        break;
                    }
            }
        }
       
    }

    void StorageMove(string action, string firstLoc, string secondLoc, int index) // 2d array storing all movements
    {
        acts[index, 0] = action;
        acts[index, 1] = firstLoc;
        acts[index, 2] = secondLoc;
    }
    void StorageGather(string action, string objtoadd, int index) // 2d array storing all gathering
    {
        acts[index, 0] = action;
        acts[index, 1] = objtoadd;
    }
    void StorageGive(string action, string objtoadd, int index) // 2d array storing all giving
    {
        acts[index, 0] = action;
        acts[index, 1] = objtoadd;
    }

    IEnumerator WaitForSpawn()
    {
        yield return new WaitForSeconds(2.0f);
        Decypher();
        yield return null;
    }
}
