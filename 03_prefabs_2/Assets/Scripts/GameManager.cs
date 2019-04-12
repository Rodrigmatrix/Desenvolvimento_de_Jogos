using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject inimigo;
    float tempo;
    void Start()
    {
        tempo = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - tempo > 3.0f)
        {
            GameObject go = Instantiate(inimigo) as GameObject;
            go.gameObject.transform.position = new Vector3(Random.Range(-3f, 3.0f), (0.5f), Random.Range(-3f, 3.0f));
            tempo = Time.time;
        }
    }
}
