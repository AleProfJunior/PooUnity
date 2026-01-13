using System;
using System.Collections;
using UnityEngine;

public abstract class Personagem : MonoBehaviour, IDanificavel
{
    protected Rigidbody rigidBody;
    [SerializeField] public Atributos Atributos;
    protected virtual void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    protected virtual void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent(out IDanificavel danificavel))
        {
            danificavel.AplicarDano(Atributos.dano);
        }
    }
    
    public void AplicarDano(int dano)
    {
        Atributos.vida -= dano;
        if (Atributos.vida <= 0)
        {
            Morrer();
        }
    }

    protected void Mover(Vector3 direcao)
    {
        Vector3 velocidadeH = direcao * (Atributos.velocidade * Time.fixedDeltaTime);
        rigidBody.linearVelocity = new Vector3(velocidadeH.x, rigidBody.linearVelocity.y, velocidadeH.z);
    }

    public void Morrer()
    {
        this.gameObject.SetActive(false);
    }


    
}
