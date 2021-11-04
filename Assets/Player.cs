using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private float speed = 10.0f;
    private float JumpForce = 25.0f;
    private int JumpCount;
    private bool IsJumped;
    private Rigidbody2D rb;
    public GameObject Sprite;
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
            Destroy(Sprite, 0f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        IsJumped = true; //If Player touches any collision
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
        if ((Input.GetKeyDown("w") || Input.GetKeyDown("space")) && JumpCount < 2 && IsJumped) //For Double Jump
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
