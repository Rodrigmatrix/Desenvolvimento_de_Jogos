using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacao : MonoBehaviour {

	// Use this for initialization
	public GameObject prefab;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow))
		{
			this.gameObject.transform.Translate (Vector3.forward * 0.2f);
		}
		else if (Input.GetKey(KeyCode.DownArrow))
		{
			this.gameObject.transform.Translate (Vector3.forward * -0.2f);
		}
		else if(Input.GetKey(KeyCode.RightArrow))
		{
			this.gameObject.transform.Rotate (this.gameObject.transform.up * 5f);
		}
		else if(Input.GetKey(KeyCode.LeftArrow))
		{
			this.gameObject.transform.Rotate (this.gameObject.transform.up * -5f);
		}
		if(Input.GetKeyDown(KeyCode.Space))
		{
			GameObject go = Instantiate (prefab) as GameObject;
			go.transform.position = this.transform.position + (this.gameObject.transform.forward * 1.0f);
			go.transform.rotation = this.gameObject.transform.rotation;
			go.GetComponent<Rigidbody> ().AddForce (go.transform.forward * 1000.0f);
		}

	}
}
