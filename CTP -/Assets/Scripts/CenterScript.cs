using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterScript : MonoBehaviour
{
    public GameObject tetheredTile;

	void Update ()
    {
        this.gameObject.transform.position = tetheredTile.transform.position;
	}
}
