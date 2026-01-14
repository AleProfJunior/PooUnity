using System;
using TMPro;
using UnityEngine;

public class Erro1  : MonoBehaviour
{
    private string nome = "Clique com o mouse";
    private int idade = 55;


    private void Awake()
    {
        GetComponent<TMP_Text>().SetText(nome);
    }
}
