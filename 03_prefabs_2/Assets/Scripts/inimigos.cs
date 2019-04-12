using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigos : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update ()
    {
        this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, 
            player.transform.position, 0.005f);
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "projetil")
		{
			Destroy (col.gameObject);
			Destroy (this.gameObject);
		}

	}
}
