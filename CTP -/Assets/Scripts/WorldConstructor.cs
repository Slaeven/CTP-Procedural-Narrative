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
    private int centerCount = 0;
    private GameObject dayNight;
    private bool doneOnce = false;
    private bool doneOnce2 = false;
    private GameObject[] particles;

	void Start ()
    {
        dayNight = GameObject.FindGameObjectWithTag("rotator");
        particles = GameObject.FindGameObjectsWithTag("Particle");
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
            if (centerCount == 4 && !doneOnce)
            {
                doneOnce = true;
                dayNight.transform.position = spawnLocation;
            }

            centerCount++;
            location.transform.position = spawnLocation;
        }

	}

    private void Update()
    {
        if (dayNight.GetComponent<DayNightCycle>().GetDay() == true)
        {
            foreach (GameObject part in particles)
            {
                part.GetComponent<ParticleSystem>().Stop();
            }           
        }
        else if(dayNight.GetComponent<DayNightCycle>().GetDay() == false)
        {
            if (!doneOnce2)
            {
                doneOnce2 = true;
                foreach (GameObject part in particles)
                {
                    part.GetComponent<ParticleSystem>().Play();
                }
            }
        }

    }

}
