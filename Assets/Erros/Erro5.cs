using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

    public class Erro5 : MonoBehaviour
    {
        [SerializeField] private List<Transform> cubos;
        private int index = 0;
        private void Awake()
        {
            cubos = GetComponentsInChildren<Transform>().ToList();
            cubos.RemoveAt(0);
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Destroy(cubos[index].gameObject);
                index++;
            }
        }
    }
