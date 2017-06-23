using UnityEngine;
using System.Collections;


public class HitVelDetection : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collision2D) {

		if (collision2D.relativeVelocity.magnitude > 35)
			Destroy(gameObject);
	}
}