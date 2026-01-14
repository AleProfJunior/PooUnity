using System;
using UnityEngine;


    public class Erro4 : MonoBehaviour
    {
        [SerializeField] private float speed = 3;
        private Rigidbody rigidbody;

        private void Awake()
        {
            rigidbody  = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                rigidbody.AddForce(Vector3.up * speed, ForceMode.Impulse);
            }
        }
    }
