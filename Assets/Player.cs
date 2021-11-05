using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed = 10.0f;
    [SerializeField]
    private float JumpForce = 25.0f;
    private int JumpCount;
    private bool IsJumped;
    private Rigidbody2D rb;
    public GameObject Sprite;
    private Animator anim;
    private int move;
    private bool isFacingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        JumpCount = 0;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Killable")
        {
            death();
        }
        IsJumped = true; //If Player touches any collision
       JumpCount = 0;
    }
    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", Mathf.Abs(move));
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
           
            anim.SetFloat("Speed", Mathf.Abs(move));
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
       
            anim.SetFloat("Speed", Mathf.Abs(move));
        }
        if ((Input.GetKeyDown("w") || Input.GetKeyDown("space") || Input.GetKeyDown(KeyCode.UpArrow)) && JumpCount < 2 && IsJumped) //For Double Jump
        {
            rb.velocity = new Vector3(0, JumpForce, 0);
            JumpCount++;
        }
        if(JumpCount > 2)
        {
            IsJumped = false;
        }

        if (move > 0 && !isFacingRight)
        {
            Flip();
        }
        else if(move < 0 && isFacingRight)
        {
            Flip();
        }
    }
    

    public void death()
    {
        Destroy(Sprite, 0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    
    }
}
