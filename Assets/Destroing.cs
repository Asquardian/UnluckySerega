using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroing : MonoBehaviour
{
    // Start is called before the first frame update

    private bool isDestroyeble = false;

    void Start()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
           
        }
        if (collision.gameObject.tag == "Safe") 
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
