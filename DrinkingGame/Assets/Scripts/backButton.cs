using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backButton : MonoBehaviour
{


    public Button backButtonz;


    // Start is called before the first frame update
    void Start()
    {
        backButtonz = backButtonz.GetComponent<Button>();
        backButtonz.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        Debug.Log("Home");
        Application.LoadLevel("Home");

    }
}
