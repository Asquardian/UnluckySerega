using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    [SerializeField]
   private float _speed =10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);

        if (transform.position.x <= -12f)
        {
            
            Destroy(this.gameObject);

        }
  
}


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Player")
        {
            Player player = collision.transform.GetComponent<Player>();
            Destroy(this.gameObject);
            player.death();
            

        }
    }
}
