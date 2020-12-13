using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XMASPicker : MonoBehaviour
{
    public Button nextButton;

    string whichTask;
    public Text taskText;
    public GameObject taskTextV;
    public GameObject xmas1;
    public GameObject xmas2;
    public GameObject xmas3;
    public GameObject xmas4;
    public GameObject xmas5;
    public GameObject xmas6;
    public GameObject xmas7;
    public GameObject xmas8;
    public GameObject xmas9;
    public GameObject xmas10;
    public GameObject xmas11;
    public GameObject xmas12;
    public GameObject xmas13;
    public GameObject xmas14;
    public GameObject xmas15;
    public GameObject xmas16;
    public GameObject xmas17;
    public GameObject xmas18;
    public GameObject xmas19;
    public GameObject xmas20;
    public GameObject xmas21;
    public GameObject xmas22;
    public GameObject xmas23;
    public GameObject xmas24;
    public GameObject xmas25;
    public GameObject xmas26;
    public GameObject xmas27;
    public GameObject xmas28;
    public GameObject xmas29;
    public GameObject xmas30;
    public GameObject xmas31;
    public GameObject xmas32;
    public GameObject xmas33;
    public GameObject xmas34;
    public GameObject xmas35;
    public GameObject xmas36;
    public GameObject xmas37;
    public GameObject xmas38;
    public GameObject xmas39;

    //make a new list with all the tasks 
    public List<string> TaskList = new List<string>();


    // Start is called before the first frame update
    void Start()
    {
        taskTextV.SetActive(false);
        xmas1.SetActive(false);
        xmas2.SetActive(false);
        xmas3.SetActive(false);
        xmas4.SetActive(false);
        xmas5.SetActive(false);
        xmas6.SetActive(false);
        xmas7.SetActive(false);
        xmas8.SetActive(false);
        xmas9.SetActive(false);
        xmas10.SetActive(false);
        xmas11.SetActive(false);
        xmas12.SetActive(false);
        xmas13.SetActive(false);
        xmas14.SetActive(false);
        xmas15.SetActive(false);
        xmas16.SetActive(false);
        xmas17.SetActive(false);
        xmas18.SetActive(false);
        xmas19.SetActive(false);
        xmas20.SetActive(false);
        xmas21.SetActive(false);
        xmas22.SetActive(false);
        xmas23.SetActive(false);
        xmas24.SetActive(false);
        xmas25.SetActive(false);
        xmas26.SetActive(false);
        xmas27.SetActive(false);
        xmas28.SetActive(false);
        xmas29.SetActive(false);
        xmas30.SetActive(false);
        xmas30.SetActive(false);
        xmas31.SetActive(false);
        xmas32.SetActive(false);
        xmas33.SetActive(false);
        xmas34.SetActive(false);
        xmas35.SetActive(false);
        xmas36.SetActive(false);
        xmas37.SetActive(false);
        xmas38.SetActive(false);
        xmas39.SetActive(false);

        //initialise the list with values
        TaskList.Add("xmas1");
        TaskList.Add("xmas2");
        TaskList.Add("xmas3");
        TaskList.Add("xmas4");
        TaskList.Add("xmas5");
        TaskList.Add("xmas6");
        TaskList.Add("xmas7");
        TaskList.Add("xmas8");
        TaskList.Add("xmas9");
        TaskList.Add("xmas10");
        TaskList.Add("xmas11");
        TaskList.Add("xmas12");
        TaskList.Add("xmas13");
        TaskList.Add("xmas14");
        TaskList.Add("xmas15");
        TaskList.Add("xmas16");
        TaskList.Add("xmas17");
        TaskList.Add("xmas18");
        TaskList.Add("xmas19");
        TaskList.Add("xmas20");
        TaskList.Add("xmas21");
        TaskList.Add("xmas22");
        TaskList.Add("xmas23");
        TaskList.Add("xmas24");
        TaskList.Add("xmas25");
        TaskList.Add("xmas26");
        TaskList.Add("xmas27");
        TaskList.Add("xmas28");
        TaskList.Add("xmas29");
        TaskList.Add("xmas30");
        TaskList.Add("xmas31");
        TaskList.Add("xmas32");
        TaskList.Add("xmas33");
        TaskList.Add("xmas34");
        TaskList.Add("xmas35");
        TaskList.Add("xmas36");
        TaskList.Add("xmas37");
        TaskList.Add("xmas38");
        TaskList.Add("xmas39");

        //initalise button
        nextButton = nextButton.GetComponent<Button>();
        nextButton.onClick.AddListener(TaskOnClick);

        //pick random count from the list
        string taskChose = TaskList[Random.Range(0, TaskList.Count - 1)];

        //set gameobject chosen to visible 
        if (taskChose == "xmas1")
        {
            xmas1.SetActive(true);
        }
        if (taskChose == "xmas2")
        {
            xmas2.SetActive(true);
        }
        if (taskChose == "xmas3")
        {
            xmas3.SetActive(true);
        }
        if (taskChose == "xmas4")
        {
            xmas4.SetActive(true);
        }
        if (taskChose == "xmas5")
        {
            xmas5.SetActive(true);
        }
        if (taskChose == "xmas6")
        {
            xmas6.SetActive(true);
        }
        if (taskChose == "xmas7")
        {
            xmas7.SetActive(true);
        }
        if (taskChose == "xmas8")
        {
            xmas8.SetActive(true);
        }
        if (taskChose == "xmas9")
        {
            xmas9.SetActive(true);
        }
        if (taskChose == "xmas10")
        {
            xmas10.SetActive(true);
        }
        if (taskChose == "xmas11")
        {
            xmas11.SetActive(true);
        }
        if (taskChose == "xmas12")
        {
            xmas12.SetActive(true);
        }
        if (taskChose == "xmas13")
        {
            xmas13.SetActive(true);
        }
        if (taskChose == "xmas14")
        {
            xmas14.SetActive(true);
        }
        if (taskChose == "xmas15")
        {
            xmas15.SetActive(true);
        }
        if (taskChose == "xmas16")
        {
            xmas16.SetActive(true);
        }
        if (taskChose == "xmas17")
        {
            xmas17.SetActive(true);
        }
        if (taskChose == "xmas18")
        {
            xmas18.SetActive(true);
        }
        if (taskChose == "xmas19")
        {
            xmas19.SetActive(true);
        }
        if (taskChose == "xmas20")
        {
            xmas20.SetActive(true);
        }
        if (taskChose == "xmas21")
        {
            xmas21.SetActive(true);
        }
        if (taskChose == "xmas22")
        {
            xmas22.SetActive(true);
        }
        if (taskChose == "xmas23")
        {
            xmas23.SetActive(true);
        }
        if (taskChose == "xmas24")
        {
            xmas24.SetActive(true);
        }
        if (taskChose == "xmas25")
        {
            xmas25.SetActive(true);
        }
        if (taskChose == "xmas26")
        {
            xmas26.SetActive(true);
        }
        if (taskChose == "xmas27")
        {
            xmas27.SetActive(true);
        }
        if (taskChose == "xmas28")
        {
            xmas28.SetActive(true);
        }
        if (taskChose == "xmas29")
        {
            xmas29.SetActive(true);
        }
        if (taskChose == "xmas30")
        {
            xmas30.SetActive(true);
        }
        if (taskChose == "xmas31")
        {
            xmas31.SetActive(true);
        }
        if (taskChose == "xmas32")
        {
            xmas32.SetActive(true);
        }
        if (taskChose == "xmas33")
        {
            xmas33.SetActive(true);
        }
        if (taskChose == "xmas34")
        {
            xmas34.SetActive(true);
        }
        if (taskChose == "xmas35")
        {
            xmas35.SetActive(true);
        }
        if (taskChose == "xmas36")
        {
            xmas36.SetActive(true);
        }
        if (taskChose == "xmas37")
        {
            xmas37.SetActive(true);
        }
        if (taskChose == "xmas38")
        {
            xmas38.SetActive(true);
        }
        if (taskChose == "xmas39")
        {
            xmas39.SetActive(true);
        }
        

        //remove that card so the player doesnt get duplicate cards
        TaskList.Remove(taskChose);

    }

    // Update is called once per frame
    void Update()
    {
       
        if (TaskList.Count < 1)
        {
            taskTextV.SetActive(true);
            taskText.text = "You've gone through all the cards.";

        }

       
    }

    void TaskOnClick()
    {

        taskTextV.SetActive(false);
        xmas1.SetActive(false);
        xmas2.SetActive(false);
        xmas3.SetActive(false);
        xmas4.SetActive(false);
        xmas5.SetActive(false);
        xmas6.SetActive(false);
        xmas7.SetActive(false);
        xmas8.SetActive(false);
        xmas9.SetActive(false);
        xmas10.SetActive(false);
        xmas11.SetActive(false);
        xmas12.SetActive(false);
        xmas13.SetActive(false);
        xmas14.SetActive(false);
        xmas15.SetActive(false);
        xmas16.SetActive(false);
        xmas17.SetActive(false);
        xmas18.SetActive(false);
        xmas19.SetActive(false);
        xmas20.SetActive(false);
        xmas21.SetActive(false);
        xmas22.SetActive(false);
        xmas23.SetActive(false);
        xmas24.SetActive(false);
        xmas25.SetActive(false);
        xmas26.SetActive(false);
        xmas27.SetActive(false);
        xmas28.SetActive(false);
        xmas29.SetActive(false);
        xmas30.SetActive(false);
        xmas30.SetActive(false);
        xmas31.SetActive(false);
        xmas32.SetActive(false);
        xmas33.SetActive(false);
        xmas34.SetActive(false);
        xmas35.SetActive(false);
        xmas36.SetActive(false);
        xmas37.SetActive(false);
        xmas38.SetActive(false);
        xmas39.SetActive(false);

        string taskChose = TaskList[Random.Range(0, TaskList.Count - 1)];

        // taskText.text = taskChose;

        if (taskChose == "xmas1")
        {
            xmas1.SetActive(true);
        }
        if (taskChose == "xmas2")
        {
            xmas2.SetActive(true);
        }
        if (taskChose == "xmas3")
        {
            xmas3.SetActive(true);
        }
        if (taskChose == "xmas4")
        {
            xmas4.SetActive(true);
        }
        if (taskChose == "xmas5")
        {
            xmas5.SetActive(true);
        }
        if (taskChose == "xmas6")
        {
            xmas6.SetActive(true);
        }
        if (taskChose == "xmas7")
        {
            xmas7.SetActive(true);
        }
        if (taskChose == "xmas8")
        {
            xmas8.SetActive(true);
        }
        if (taskChose == "xmas9")
        {
            xmas9.SetActive(true);
        }
        if (taskChose == "xmas10")
        {
            xmas10.SetActive(true);
        }
        if (taskChose == "xmas11")
        {
            xmas11.SetActive(true);
        }
        if (taskChose == "xmas12")
        {
            xmas12.SetActive(true);
        }
        if (taskChose == "xmas13")
        {
            xmas13.SetActive(true);
        }
        if (taskChose == "xmas14")
        {
            xmas14.SetActive(true);
        }
        if (taskChose == "xmas15")
        {
            xmas15.SetActive(true);
        }
        if (taskChose == "xmas16")
        {
            xmas16.SetActive(true);
        }
        if (taskChose == "xmas17")
        {
            xmas17.SetActive(true);
        }
        if (taskChose == "xmas18")
        {
            xmas18.SetActive(true);
        }
        if (taskChose == "xmas19")
        {
            xmas19.SetActive(true);
        }
        if (taskChose == "xmas20")
        {
            xmas20.SetActive(true);
        }
        if (taskChose == "xmas21")
        {
            xmas21.SetActive(true);
        }
        if (taskChose == "xmas22")
        {
            xmas22.SetActive(true);
        }
        if (taskChose == "xmas23")
        {
            xmas23.SetActive(true);
        }
        if (taskChose == "xmas24")
        {
            xmas24.SetActive(true);
        }
        if (taskChose == "xmas25")
        {
            xmas25.SetActive(true);
        }
        if (taskChose == "xmas26")
        {
            xmas26.SetActive(true);
        }
        if (taskChose == "xmas27")
        {
            xmas27.SetActive(true);
        }
        if (taskChose == "xmas28")
        {
            xmas28.SetActive(true);
        }
        if (taskChose == "xmas29")
        {
            xmas29.SetActive(true);
        }
        if (taskChose == "xmas30")
        {
            xmas30.SetActive(true);
        }
        if (taskChose == "xmas31")
        {
            xmas31.SetActive(true);
        }
        if (taskChose == "xmas32")
        {
            xmas32.SetActive(true);
        }
        if (taskChose == "xmas33")
        {
            xmas33.SetActive(true);
        }
        if (taskChose == "xmas34")
        {
            xmas34.SetActive(true);
        }
        if (taskChose == "xmas35")
        {
            xmas35.SetActive(true);
        }
        if (taskChose == "xmas36")
        {
            xmas36.SetActive(true);
        }
        if (taskChose == "xmas37")
        {
            xmas37.SetActive(true);
        }
        if (taskChose == "xmas38")
        {
            xmas38.SetActive(true);
        }
        if (taskChose == "xmas39")
        {
            xmas39.SetActive(true);
        }

        TaskList.Remove(taskChose);

    }


}
