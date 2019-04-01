using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectil : MonoBehaviour {
	float start;
	// Use this for initialization
	void Start () {
		start = Time.time;
	}

	// Update is called once per frame
	void Update () {
		//this.gameObject.transform.Translate (Vector3.forward * 0.2f);
		if ((Time.time - start) > 1.0f)
		{
			Destroy (this.gameObject);
		}
	}
}
