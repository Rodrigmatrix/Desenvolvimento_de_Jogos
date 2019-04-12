using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pontuacao : MonoBehaviour
{
    // Start is called before the first frame update
    int pontos;
    public Text pontosUI;
    void Start()
    {
        pontos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void adicionar_ponto()
    {
        this.pontos++;
        this.pontosUI.text = this.pontos.ToString();
    }
}
