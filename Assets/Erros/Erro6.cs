using UnityEngine;

    public class Erro6 : MonoBehaviour
    {
        [SerializeField] private float speed = 20;

        private void Update()
        {
           transform.Rotate(Vector3.up * Time.deltaTime * speed);
        }
    }
