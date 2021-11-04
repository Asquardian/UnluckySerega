using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 10.0f;
    private float JumpForce = 25.0f;
    private int JumpCount;
    private bool IsJumped;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        JumpCount = 0;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Killable")
        {
            Destroy(gameObject, 0f);
        }
        IsJumped = true;
       JumpCount = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if ((Input.GetKeyDown("w") || Input.GetKeyDown("space")) && JumpCount < 2 && IsJumped)
        {
            rb.velocity = new Vector3(0, JumpForce, 0);
            JumpCount++;
        }
        if(JumpCount > 2)
        {
            IsJumped = false;
        }
    }
}
