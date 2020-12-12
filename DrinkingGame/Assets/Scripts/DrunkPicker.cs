using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrunkPicker : MonoBehaviour
{
    public Button nextButton;

    string whichTask;
    public Text taskText;

    //make a new list with all the tasks 
    public List<string> TaskList = new List<string>();


    // Start is called before the first frame update
    void Start()
    {
        //initialise the list with values
        TaskList.Add("Never have I ever had sex in public (drink if you have).");
        TaskList.Add("Waterfall (keep drinking till the person next to you stops).");
        TaskList.Add("Fuck Marry Kill (the group picks 3 people).");
        TaskList.Add("Everyone must drink double for one round.");
        TaskList.Add("Paranoia (whisper a question to the person to your left, they say the answer out loud. Flip a  coin, if it lands on heads, reveal the question, if it lands on tails, don’t reveal the question. Repeat for one whole round).");
        TaskList.Add("Most sober finishes their drink.");
        TaskList.Add("Pick a drinking buddy.");
        TaskList.Add("Drink twice.");
        TaskList.Add("Drink your body count, if it's 0, down your drink.");
        TaskList.Add("Take a sip to everyone you’d hookup with on the table");
        TaskList.Add("Choose a lap to sit on for one round.");
        TaskList.Add("Suck & Blow (use any card/credit card you can find)");
        TaskList.Add("What’s the last name of the person to your right, if you can’t say it, drink 3 sips.");
        TaskList.Add("Whoever swears next, drink 4 sips. (keep the rule for one whole round).");
        TaskList.Add("Fill up your cup then down it.");
        TaskList.Add("Say the alphabet backwards or drink.");
        TaskList.Add("Players with tattoos must drink.");
        TaskList.Add("Hum a song- the first player to guess it can give 3 sips out.");
        TaskList.Add("Point to whoever is most likely to black out tonight (most pointed at, drinks).");
        TaskList.Add("Every player must read their last text out loud or take 3 sips.");
        TaskList.Add("Quote a movie, whoever guesses it first can give 4 sips away.");
        TaskList.Add("You can’t tell the truth for a whole round, when someone catches you telling the truth, you need to drink.");
        TaskList.Add("If you’ve ever kissed one of the players in the group, drink.");
        TaskList.Add("The player opposite you must drink.");
        TaskList.Add("Blondes drink.");
        TaskList.Add("All singles must drink.");
        TaskList.Add("Mute till your next turn, drink for everytime you speak.");
        TaskList.Add("Take a shot or remove a piece of clothing.");
        TaskList.Add("Group selects the most sober to take a shot.");
        TaskList.Add("Let the group pour a mystery shot.");
        TaskList.Add("What is your favorite type of porn? Answer or drink.");
        TaskList.Add("Drink if you’ve faked an orgasm.");
        TaskList.Add("Drink if you’ve been ghosted.");
        TaskList.Add("Drink if you swallow.");
        TaskList.Add("Drink if you’ve drunk texted your EX.");
        TaskList.Add("Drink if you’ve had braces.");
        TaskList.Add("Take a shot with no hands.");
        TaskList.Add("Body shot with the person opposite you.");
        TaskList.Add("Pick 2 players, they have to kiss or take a shot.");
        TaskList.Add("Fi yuo cna raed tihs then drink.");
        TaskList.Add("Starting with you go around the group naming, car brands, Whoever can’t drink.");
        TaskList.Add("RIP. Down your drink and take a shot.");
        TaskList.Add("Go around the group counting from 1 upwards. Substituting any multiple of 4 with a random number. Whoever says a multiple of 4 must drink.");
        TaskList.Add("All players start drinking, they can only stop when you stop drinking.");
        TaskList.Add("Anyone who claims they are not drunk must drink.");
        TaskList.Add("Go around the room and say everyone's last name, drink for everytime you can't.");
        TaskList.Add("Sample14");
        TaskList.Add("Sample14");

        //initalise button
        nextButton = nextButton.GetComponent<Button>();
        nextButton.onClick.AddListener(TaskOnClick);

        //pick random count from the list
        string taskChose = TaskList[Random.Range(0, TaskList.Count - 1)];

        //set text to the chosen count of list
        taskText.text = taskChose;
        //remove that card so the player doesnt get duplicate cards
        TaskList.Remove(taskChose);

    }

    // Update is called once per frame
    void Update()
    {
        if (TaskList.Count < 1)
        {

            taskText.text = "You've gone through all the cards.";

        }
    }

    void TaskOnClick()
    {

        string taskChose = TaskList[Random.Range(0, TaskList.Count - 1)];

        taskText.text = taskChose;
        TaskList.Remove(taskChose);


    }


}
