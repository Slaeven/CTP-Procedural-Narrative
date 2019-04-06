using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Location : MonoBehaviour
{
    public bool safe;
    public NavMeshSurface navMesh;

	void Start ()
    {
        navMesh = gameObject.GetComponent<NavMeshSurface>();
	}

    void BuildMesh()
    {
        navMesh.BuildNavMesh();
    }

    void ClearMesh()
    {
        
    }

    public bool GetSafety()
    {
        return safe;
    }
}
