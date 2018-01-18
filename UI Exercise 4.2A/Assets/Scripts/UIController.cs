using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public Text myText;
    public InputField userInput;
    int num1;
    int num2;

    System.Random rand = new System.Random();

	// Use this for initialization
	void Start () {

        GenerateQuestion();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CheckAnswer()
    {
        int userAnswer = int.Parse(userInput.text);
        int multAnswer = num1 * num2;

        if (userAnswer == multAnswer)
        {
            print("Correct!");
            GenerateQuestion();
        }
        else
        {
            print("Incorrect");
        }
    }

    void GenerateQuestion()
    {
        userInput.text = "";

        num1 = rand.Next(1, 11);
        num2 = Random.Range(1, 11);

        myText.text = "What is " + num1 + " x " + num2 + "?"; // write
    }

    public void QuitUnity()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
