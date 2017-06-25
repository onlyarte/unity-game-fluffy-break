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
            StartCoroutine(setPosition(latePosition));
        }
            else
        {
            if (Point)
            {
                //Destroy(point);
            }
        }
	}

    IEnumerator setPosition(Vector3 newPos)
    {
        yield return new WaitForSeconds(.5f);
        newPos.y += 0.2f;
        Point.transform.position = newPos;
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
