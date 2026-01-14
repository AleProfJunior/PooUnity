using System;
using UnityEngine;


    public class Erro3 : MonoBehaviour
    {
        [SerializeField] private float speed = 3;
        [SerializeField] private Transform alvo;


        private void Update()
        {
            transform.position = Vector3.Lerp(transform.position, alvo.position + Vector3.up, speed * Time.deltaTime);
        }
    }
