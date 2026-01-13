using System;
using UnityEngine;

public class CoracoesJogadorControlador : MonoBehaviour
{
    [SerializeField] private Jogador jogador;

    [SerializeField] private GameObject[] coracoes;

    private void FixedUpdate()
    { 
        int quantidadeVida = jogador.GetVida;
        for (int i = 0; i < coracoes.Length; i++)
        {
            if (quantidadeVida > i)
            { 
                coracoes[i].SetActive(true);
            }
            else
            {
                coracoes[i].SetActive(false);
            }
        }
    }
}
