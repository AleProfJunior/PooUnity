using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text text_tempo;
    [SerializeField] private Jogador jogador;
    [SerializeField] private GameObject gameoverTela;
    
    private void Start()
    {
        gameoverTela.SetActive(false);
        StartCoroutine(Temporizador());
    }

    private void OnDestroy()
    {
        StopCoroutine(Temporizador());
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

    public IEnumerator Temporizador()
    {
        while (true)
        {
            var time = TimeSpan.FromSeconds(Time.timeSinceLevelLoad);
            var tempoFormatado = $"{time.Minutes:00}:{time.Seconds:00}";
            text_tempo.SetText(tempoFormatado);
            yield return new WaitForSeconds(1);


        }
    }
}
