using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    private int col = 0;
    public Text Num;
    public void Add()
    {
        col++;
        Num.text = "Ёссенции: " + col.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        Num.text = "Ёссенции: " + col.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
