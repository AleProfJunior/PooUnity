using System;
using UnityEngine;


    public class Erro2 : MonoBehaviour
    {
        private Transform transform;
        [SerializeField] private float speed;
        [SerializeField] private float altura = 100;
        private void Awake()
        {
            transform = gameObject.transform;
        }

        private void Update()
        {
            this.transform.position = Vector3.right* Mathf.PingPong(Time.time * speed, altura);
        }
    }
