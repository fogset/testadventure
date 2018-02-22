using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour {
    int max, min, guess;
    // Use this for initialization
    void Start () {
        StarGame();
    }

    void StarGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        print("=================================");
        print("=================================");
        print("Welcome to Number Wizard");
        print("Put a number in your head but dont tell me!");

        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);

        print("Is the number higher or lower than " + guess + "?");
        print("Up = higher, down = lower and return = equal");
        max = max + 1;
    }
	void NextGuess()
    {
        guess = (max + min) / 2;
        print("Higher or lower than " + guess);
        print("Up = higher, down = lower and return = equal");
    }
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
            StarGame();
        }
    }
}
