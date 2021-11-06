using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField]
    private float _speed = 12.0f;

    private void Update()
    {
        
            transform.Translate(Vector3.right * _speed * Time.deltaTime);


       
    }



    private void Start()
    {
        Destroy(gameObject, 5);
    }
}
