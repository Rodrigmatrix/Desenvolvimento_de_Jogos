using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacao : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.transform.position += new Vector3(0.2f, 0, 0);
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            this.gameObject.transform.position += new Vector3(-0.2f, 0, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            this.gameObject.transform.position += new Vector3(0.2f, 0, 0.2f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.gameObject.transform.position += new Vector3(-0.2f, 0, -0.2f);
        }
    }
}
