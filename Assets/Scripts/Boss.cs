using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    private Player _player;
    [SerializeField]
    private GameObject _fireBallPrefab;
    private float _fireRate = 3.0f;
    private float _canFire = -1;
    private int _lives = 10;
    public Text Lives;
    // Start is called before the first frame update
    void Start()
    {
        Lives.text = "������: " + _lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
       

       
        if (Time.time > _canFire)
        {
            _fireRate = 1f;
            _canFire = Time.time + _fireRate;
            GameObject fireBall = Instantiate(_fireBallPrefab, new Vector3(transform.position.x, Random.Range(-4f, 5f), 0), Quaternion.identity);
          

        
        }
        


    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "knife")
        {
            damage();
        }
    }

    public void damage()
    {
        _lives--;
        Lives.text = "������: " + _lives.ToString();

        if (_lives <=0)
        {
            Destroy(this.gameObject);
        }
    }


    
}
