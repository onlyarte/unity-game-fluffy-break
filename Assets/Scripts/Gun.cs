using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    GameObject Point;
    float pointRange = 1.3f;


	// Use this for initialization
	void Start () {
        Vector3 newPosition = getPlayerPosition() + new Vector3(2, 2, 0);
        Point = Instantiate(Resources.Load("Prefabs/Point"), newPosition, transform.rotation) as GameObject;
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
                Destroy(Point);
            }
        }
	}

    IEnumerator setPosition(Vector3 newPos)
    {
        yield return new WaitForSeconds(.5f);
        newPos.y += pointRange;
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

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("death");
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        OnTriggerEnter2D(collider);
    }
}
