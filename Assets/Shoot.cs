using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Rigidbody2D item;
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("shoot");
            item.velocity = new Vector3(-30f, 0, 0);
            Destroy(gameObject, 0f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
