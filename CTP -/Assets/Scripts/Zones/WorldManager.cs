using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WorldManager : MonoBehaviour
{
    private float timer = 0;
    public List<NavMeshSurface> navMeshs = new List<NavMeshSurface>();
    public GameObject[] navLinks;
    public GameObject[] Locations;
    private bool locationsFound = false;

    void Start ()
    {

	}
	
	void Update ()
    {
        timer += Time.deltaTime;
        foreach (GameObject loc in Locations)
        {
            if (loc.GetComponent<Location>().GetSafety() != true)
            {
                //loc.GetComponent<NavMeshSurface>().agentTypeID = 0;
            }
        }
        if (timer >= 5)
        {
            timer = 0;

            foreach (NavMeshSurface mesh in navMeshs)
            {
                mesh.BuildNavMesh();
                Debug.Log("baked");
            }
        }
        if (timer >= 2 && locationsFound == false)
        {
            locationsFound = true;
            Locations = GameObject.FindGameObjectsWithTag("Location");
            navLinks = GameObject.FindGameObjectsWithTag("Link");
            foreach (GameObject loc in Locations)
            {
                navMeshs.Add(loc.GetComponent<NavMeshSurface>());
            }
            foreach (GameObject link in navLinks)
            {
                link.SetActive(false);
                link.SetActive(true);
            }
        }
    }
}
