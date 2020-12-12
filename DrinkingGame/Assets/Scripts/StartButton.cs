using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{

    public Button backButton;


    // Start is called before the first frame update
    void Start()
    {
        backButton = backButton.GetComponent<Button>();
        backButton.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void TaskOnClick()
    {
        Debug.Log("SampleScene");
        Application.LoadLevel("SampleScene");

    }
}
