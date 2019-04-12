using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
            GameObject.FindGameObjectWithTag("GameController").GetComponent<pontuacao>().adicionar_ponto();
            Destroy (col.gameObject);
			Destroy (this.gameObject);
		}
        else if (col.gameObject.tag == "Player")
        {
            if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().life() == true)
            {
                SceneManager.LoadScene("game_over");
            }
            
        }

	}
}
