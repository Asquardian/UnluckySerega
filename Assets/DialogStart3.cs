using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogStart3 : MonoBehaviour
{
    private bool isFinished = false;
    public Text Name;
    public Text Speech;
    public Text Action;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isFinished = true;
            Name.text = "Его имя";
            Speech.text = "О, нет, не может быть";
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (isFinished)
        {
            transform.tag = "Finish";
            Action.text = "Нажмите пробел, покажжите свою радость!";

        }
    }
}
