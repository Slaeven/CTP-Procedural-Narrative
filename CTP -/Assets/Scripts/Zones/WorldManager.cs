using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WorldManager : MonoBehaviour
{

    public List<NavMeshSurface> navMeshs = new List<NavMeshSurface>();
    public GameObject[] Locations;

    void Start ()
    {
        Locations = GameObject.FindGameObjectsWithTag("Location");
        foreach(GameObject loc in Locations)
        {
            navMeshs.Add(gameObject.GetComponent<NavMeshSurface>());
        }
        foreach (GameObject loc in Locations)
        {
            loc.GetComponent<Location>()
        }
	}
	
	void Update ()
    {
		
	}
}
