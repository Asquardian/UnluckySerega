using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public  GameObject spike;
    private void Start()
    {
        spike = GameObject.Find("Trap");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("collision done");
            spike.transform.position = new Vector3(-0.1099997f, -3.88f, 0);
            Destroy(this.gameObject);
        }
    }
}
