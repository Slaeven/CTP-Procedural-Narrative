using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldConstructor : MonoBehaviour
{

    public GameObject[] locations;
    private GameObject newLocation;
    private Vector3 spawnLocation = new Vector3(0, 0, 0);
    public int previousMove = 0;
    public int choice = 0;

	void Start ()
    {
        locations = GameObject.FindGameObjectsWithTag("Location"); // Randomises and adds to an array


        for (int positionOfArray = 0; positionOfArray < locations.Length; positionOfArray++)
        {
            GameObject obj = locations[positionOfArray];
            int randomiseArray = Random.Range(0, positionOfArray);
            locations[positionOfArray] = locations[randomiseArray];
            locations[randomiseArray] = obj;
        }

        foreach(GameObject location in locations)
        {
            choice = Random.Range(-1, 2);
            //Debug.Log(choice);

            if (choice == -1 && previousMove == 1)
            {
                choice = Random.Range(0,1);
            }
            if(choice == 1 && previousMove == -1)
            {
                choice = Random.Range(-1, 0);
            }

            switch (choice) // decides which way to go
            {
                case 0:
                    {
                        spawnLocation += new Vector3 (0,0,-10); // right
                        previousMove = 0;
                        break;
                    }
                case -1:
                    {
                        spawnLocation += new Vector3(-10, 0, 0); // down
                        previousMove = -1;
                        break;
                    }
                case 1:
                    {
                        spawnLocation += new Vector3(10, 0, 0); // up
                        previousMove = 1;
                        break;
                    }
            }
            
            location.transform.position = spawnLocation;
        }

	}
	
	void Update ()
    {
		
	}
}
