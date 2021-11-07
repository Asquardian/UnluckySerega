using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Load : MonoBehaviour
{
    public Button yourButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        int indx = SceneManager.GetActiveScene().buildIndex;
        indx++;
        SceneManager.LoadScene(indx);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
