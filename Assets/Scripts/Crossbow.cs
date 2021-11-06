using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbow : MonoBehaviour
{
    [SerializeField]
    private GameObject _arrowPrefab;
    private float _fireRate = 2.0f;
    private float _canFire = -1;
    [SerializeField]
    private float _speed = 8.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > _canFire)
        {
            _fireRate = Random.Range(3f, 7f);
            _canFire = Time.time + _fireRate;
            GameObject arrow = Instantiate(_arrowPrefab, transform.position, Quaternion.identity);
           

        }
    }

   
}
