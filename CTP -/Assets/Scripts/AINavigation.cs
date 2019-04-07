using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AINavigation : MonoBehaviour
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
        if (System.IO.File.Exists(Application.dataPath + "/output1.txt") && !doneOnce)
        {
            doneOnce = true;
            string path1 = Application.dataPath + "/output1.txt";
            lines = System.IO.File.ReadAllLines(path1); // Will include empty lines. Also when importing the txt remove the numbered lines
            StartCoroutine(WaitForSpawn());
            acts = new string[50, 3];
        }
	}

    void Decypher()
    {
        for (int i = 0; i < lines.Length; i++)
        {
            words = lines[i].Split(" "[0]); // Splits lines into words

            if (words[0].Equals("move"))
            {
                string firstLoc = words[0 + 2]; // Stores first move location
                string secondLoc = words[0 + 3]; // Stores second move location
                Storage("move", firstLoc, secondLoc,i);
            }

        }
       
    }

    void  Storage(string action, string firstLoc, string secondLoc, int index) // 2d array storing all movements
    {
        acts[index, 0] = action;
        acts[index, 1] = firstLoc;
        acts[index, 2] = secondLoc;
    }

    IEnumerator WaitForSpawn()
    {
        yield return new WaitForSeconds(2.0f);
        Decypher();
        yield return null;
    }
}
