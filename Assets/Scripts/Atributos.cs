using System;
using UnityEngine;

[Serializable]
public class Atributos 
{
    public int dano = 10;
    public int vida = 100;
    public float velocidade = 100;
    
    public Atributos(int vida, int dano, float velocidade)
    {
        this.vida = vida;
        this.dano = dano;
        this.velocidade = velocidade;
    }

    
}
