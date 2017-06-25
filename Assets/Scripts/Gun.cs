using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    GameObject Point;

	// Use this for initialization
	void Start () {
        Point = Instantiate(Resources.Load("Prefabs/Point"), getPlayerPosition(), transform.rotation) as GameObject;
    }
	
	// Update is called once per frame
	void Update () {
        if (isPlayerInRange())
        {
            Vector3 latePosition = getPlayerPosition();
            StartCoroutine(WaitForSec());
            Point.transform.position = latePosition;
        }
            else
        {
            if (Point)
            {
                //Destroy(point);
            }
        }
	}

    IEnumerator setPosition()
    {
        yield return new WaitForSeconds(1f);
    }

    Vector3 getPlayerPosition()
    {
        return PlayerController.current.transform.position;
    }

    bool isPlayerInRange()
    {
        return true;
    }
}
