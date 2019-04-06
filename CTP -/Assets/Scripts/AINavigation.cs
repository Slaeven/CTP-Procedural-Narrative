using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AINavigation : MonoBehaviour
{
    public string[] lines;
    public string[] words;
    public string[,] acts;

    void Start ()
    {
        string path1 = Application.dataPath + "/output1.txt";
        lines = System.IO.File.ReadAllLines(path1); // Will include empty lines. Also when importing the txt remove the numbered lines
        StartCoroutine("WaitForSpawn");
        acts = new string[50, 50];
    }

	void Update ()
    {

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

        acts[i, 0] = action;
        acts[i, 1] = firstLoc;
        acts[i, 2] = secondLoc;

        i++;

    }

    IEnumerator WaitForSpawn()
    {
        yield return new WaitForSeconds(2.0f);
        Decypher();

        yield return null;
    }
}
