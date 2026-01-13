using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Jogador jogador;
    [SerializeField] private GameObject gameoverTela;


    private void Start()
    {
        gameoverTela.SetActive(false);
    }

    private void Update()
    {
        if (jogador.GetVida == 0)
        {
            gameoverTela.SetActive(true);
        }
    }


    public void ReiniciarCena()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
    }
}
