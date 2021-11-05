using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take : MonoBehaviour
{
    private Collect Collection;
    // Start is called before the first frame update
    void Start()
    {
        Collection = FindObjectOfType<Collect>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Collection.Add();
        }
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
