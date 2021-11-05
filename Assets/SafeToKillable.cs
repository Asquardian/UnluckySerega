using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeToKillable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Safe")
        {
            Destroy(collision.gameObject, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
