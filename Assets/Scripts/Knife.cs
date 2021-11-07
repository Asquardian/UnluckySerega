using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{

     Animator anim;

    [SerializeField]
    private bool isAttacking = false;
    public GameObject knife;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("f"))
        {
            
            StartCoroutine(knifeAttack());
        }
    }


    IEnumerator knifeAttack()
    {
        knife.SetActive(true);
        isAttacking = true;
        anim.SetBool("is attacking", isAttacking);
        yield return new WaitForSeconds(0.5f);
        knife.SetActive(false);
        isAttacking = false;
        anim.SetBool("is attacking", isAttacking);
    }
}
