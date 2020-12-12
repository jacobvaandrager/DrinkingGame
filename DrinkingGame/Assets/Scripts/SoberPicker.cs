using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoberPicker : MonoBehaviour
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
        TaskList.Add("Point to whoever is most likely to black out tonight (most pointed at, drinks).");
        TaskList.Add("Tallest & Shortest drink.");
        TaskList.Add("Paranoia - (whisper a question to the person on your left, they say the answer out loud. Flip a  coin, if it lands on heads, reveal the question, if it lands on tails, don’t reveal the question. Repeat for the whole circle.)");
        TaskList.Add("Rhyme Time - Pick a word and go around the room rhyming it. Whoever can’t, drinks.");
        TaskList.Add("Oldest & youngest drinks.");
        TaskList.Add("Whoever last had sex drinks.");
        TaskList.Add("Whoever is wearing jeans drink.");
        TaskList.Add("Pick a drinking buddy.");
        TaskList.Add("The person to your right drinks.");
        TaskList.Add("The person to your left drinks.");
        TaskList.Add("Next person to get a notification drinks.");
        TaskList.Add("Group chooses a word for you to spell, if you spell it wrong, drink 3 sips.");
        TaskList.Add("Whoever is wearing white sneakers drink.");
        TaskList.Add("Swap your drink with the fullest drink on the table.");
        TaskList.Add("If you can name the song playing right now, choose someone to drink.");
        TaskList.Add("On the count of three, all players must show a number on their hand (1-5), any players with the same number have to drink.");
        TaskList.Add("Players with tattoos must drink.");
        TaskList.Add("Every player must read their last text out loud or take 3 sips.");
        TaskList.Add("Everyone looking at this card must drink.");
        TaskList.Add("Anyone drinking vodka must drink.");
        TaskList.Add("Hum a song - the first player to guess it can give 3 sips out.");
        TaskList.Add("Starting with you, go round the table naming countries in Asia.");
        TaskList.Add("Drink twice.");
        TaskList.Add("Fill up your cup, then down it.");
        TaskList.Add("Say the alphabet backwards or drink.");
        TaskList.Add("Green eyed players drink.");
        TaskList.Add("Quote a movie, whoever guesses it first can give 4 sips away.");
        TaskList.Add("The person opposite you must drink.");
        TaskList.Add("If you’ve ever kissed one of the players in the group, drink.");
        TaskList.Add("Blondes drink.");
        TaskList.Add("Mute till your next turn, drink for everytime you speak.");
        TaskList.Add("Lowest & highest battery % drinks.");
        TaskList.Add("Make a rule for 2 rounds. Whoever breaks it must drink.");
        TaskList.Add("It’s complicated - drink.");
        TaskList.Add("Taken - drink.");
        TaskList.Add("First person to go on their phone drinks.");
        TaskList.Add("Whoever has eaten last, drink");
        TaskList.Add("Take a sip for every sibling you have");
        TaskList.Add("Take a sip for every cousin you have");
        TaskList.Add("Nicotine addicts drink");
        TaskList.Add("Anyone who has had sex with more than 10 people drink");
        TaskList.Add("Closest birthday drinks");
        TaskList.Add("Go around and name different currencies, whoever can’t, drinks.");
        TaskList.Add("Anyone who owns an Apple product must drink.");
        TaskList.Add("Everyone must drink double for one round.");
        TaskList.Add("Anyone who has thrown up from drinking, drink.");
        TaskList.Add("Anyone who has gotten hospitalised for drinking, drink.");
        TaskList.Add("Everyone drinks.");
        TaskList.Add("Everyone who has taken a picture tonight, drink.");
        TaskList.Add("You must not speak english for one round.");
        TaskList.Add("Pick a word that is banned for two rounds, anyone that says it must drink 2 sips.");
        TaskList.Add("Smokers drink.");
        TaskList.Add("Oldest player drinks.");
        TaskList.Add("Starting with you go around the group naming, car brands, whoever can’t drink.");
        TaskList.Add("Starting with you go around the group naming, clothing brands, whoever can’t drink.");
        TaskList.Add("Starting with you go around the group naming, makeup brands, whoever can’t drink.");
        TaskList.Add("Starting with you go around the group naming, fruits, whoever can’t drink.");
        TaskList.Add("You must drink once, the person next to you drinks what you drank plus one. Go around the group doing this till everyone has drunk.");
        TaskList.Add("90s kids must drink.");
        TaskList.Add("Go around the group counting from 1 upwards. Substituting any multiple of 4 with a random number. Whoever says a multiple of 4 must drink.");
        TaskList.Add("Anyone who can play an instrument, drink.");
        TaskList.Add("Bearded players must drink.");
        TaskList.Add("The player with the weakest drink must drink.");
        TaskList.Add("Cat owners drink.");
        TaskList.Add("The person with the largest ears must drink.");
        TaskList.Add("Take a sip from every person's drink.");
        TaskList.Add("Starting with you go around the group naming, countries in Europe, whoever can’t drink.");
        TaskList.Add("Drink if you have a piercing.");
        TaskList.Add("Pick a player to drink with you.");
        TaskList.Add("Try to touch the ceiling without jumping, if you can't, drink.");
        TaskList.Add("Pick three players to drink.");
        TaskList.Add("Unemployed drink.");
        TaskList.Add("Anyone drinking beer must drink.");
        TaskList.Add("The player with the longest hair must drink.");
        TaskList.Add("Youngest player must drink.");
        TaskList.Add("You and a friend have to drink double for one round.");
        TaskList.Add("Go around the room and say everyone's last name, drink for everytime you can't.");
        TaskList.Add("Anyone with a job must drink.");
        TaskList.Add("Pick a drinking buddy.");
        TaskList.Add("All singles must drink.");
        TaskList.Add("Mute till your next turn, drink for everytime you speak. ");
        TaskList.Add("Drink if you’ve been ghosted");
        TaskList.Add("Drink if you’ve drunk texted your EX");
        TaskList.Add("Drink if you’ve had braces");
        TaskList.Add("Fi yuo cna raed tihs then drink");
        TaskList.Add("Starting with you go around the group naming, car brands, Whoever can’t drink.");
        TaskList.Add("Drink if you have ever played suck and blow.");
        TaskList.Add("Drink if you have ever been hit by a car.");
        TaskList.Add("Drink if you have ever fantasised about someone in this room.");
        TaskList.Add("Everyone drinks.");
        TaskList.Add("Pick a drinking buddy.");
        TaskList.Add("Pick a drinking buddy.");
        TaskList.Add("Give out 4 sips.");
        TaskList.Add("Give out 3 sips.");
        TaskList.Add("Pick someone to drink.");

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
