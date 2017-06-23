using UnityEngine;
using System.Collections;

public class Instantiation : MonoBehaviour {

	public GameObject gameObject = null;

    void Start () {
		gameObject = Instantiate(Resources.Load("Prefabs/Cloud")) as GameObject;
	}
}
