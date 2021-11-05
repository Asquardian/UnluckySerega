using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerEvent : MonoBehaviour
{
    public Rigidbody2D Car;
    // Start is called before the first frame update
    void Start()
    {
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Car.transform.tag = "Killable";
            Car.velocity = new Vector3(0, -20, 0);
        }
        if(collision.gameObject.tag == "Killable")
        {
            Car.transform.tag = "Safe";
            Destroy(gameObject, 0.0f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
