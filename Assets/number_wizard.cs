using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class number_wizard : MonoBehaviour
{

    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update

    void StartGame()
    {
        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than my 500");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
            min = guess;
            guess = (max + min) / 2;
            Debug.Log(guess);
        }     
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down arrow key was pressed");
            max = guess;
            guess = (max + min) / 2;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You hit enter");
        }
   }
}
