using System;
using UnityEngine;

public abstract class Personagem : MonoBehaviour, IDanificavel
{
    protected Rigidbody rigidBody;
    [SerializeField] protected Atributos Atributos;
    protected Vector3 direcaoMovimento = new Vector3(1, 0, 1);
    public int GetVida => Atributos.vida;

    public event Action Morreu;
    
    private void OnEnable()
    {
        Morreu += DesativarObjeto;
    }
    private void OnDisable()
    {
        Morreu -= DesativarObjeto;
    }

    private void DesativarObjeto()
    {
        this.gameObject.SetActive(false);
    }

    protected virtual void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    protected virtual void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag(gameObject.tag))
        {
            if (other.gameObject.TryGetComponent(out IDanificavel danificavel))
            {
                danificavel.AplicarDano(Atributos.dano);
            }
        }
    }



    public void AplicarDano(int dano)
    {
        Atributos.vida -= dano;
        if (Atributos.vida <= 0)
        {
            Morreu.Invoke();
        }
    }

    protected void Mover(Vector3 direcao)
    {
        Vector3 velocidadeH = direcao.normalized * (Atributos.velocidade * Time.fixedDeltaTime);
        rigidBody.linearVelocity = new Vector3(velocidadeH.x, rigidBody.linearVelocity.y, velocidadeH.z);
    }
    
    
}
