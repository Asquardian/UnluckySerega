using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyDestroy : MonoBehaviour
{
    public GameObject Object;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(Object, 0f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
