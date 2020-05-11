using UnityEngine;

public class NumberWizard : MonoBehaviour {


    private int max;
    private int min;
    private int guess;

    // Use this for initialization
    public void Start()
    {
        initializeGame();
    }

    private void initializeGame()
    {
        print("==============================================");
        print("Welcome to Number Wizard");
        print("Pick a number in your head, but dont tell me");

        this.max = 1000;
        this.min = 1;
        this.guess = 500;

        print("The  highest number you can pick is " + max);
        print("The  lowest number you can pick is " + min);

        this.max++;

        print("Is the number higher or lower than " + guess + "?");
        print("Up = higher, down = lower, return = equal");
    }

    private void nextGuess()
    {
        guess = (max + min) / 2;
        print("Higher or lower than " + guess);
    }

    // Update is called once per frame
    public void Update () {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up arrow pressed");
            min = guess;
            nextGuess();
        }
        else  if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down arrow pressed");
            max = guess;
            nextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won");
            initializeGame();
        }

    }
}
