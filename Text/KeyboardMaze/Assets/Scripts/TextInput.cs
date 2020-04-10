using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInput : MonoBehaviour
{
    GameController gc; //GameController Object
    
    public InputField inputField; //InputField Object

    private void Awake()
    {
        gc = GetComponent<GameController>(); //Reference to GameController Script
        
        inputField.onEndEdit.AddListener(AcceptStringInput); //Listens for when the user is finished with current keyboard input
    }
    // Start is called before the first frame update
    //void Start(){}

    // Update is called once per frame
    //void Update(){}

    public void AcceptStringInput(string userInput)
    {
        userInput = userInput.ToLower(); //Convert all input text to lower case

        gc.LogStringInputWithReturn(userInput); //Mirror all input text back to the user

        char[] delimiterCharacters = { ' ' }; //An array to hold any white space from user input

        string[] separatedInputWords = userInput.Split(delimiterCharacters); //Array of user text input strings

        for (int i = 0; i < gc.inputActions.Length; i++)
        {
            InputAction inputAction = gc.inputActions[i];

            if (inputAction.actionKeyWord == separatedInputWords[0])
            {
                inputAction.RespondToInput(gc, separatedInputWords);
            }
        }

        InputComplete();
    }

    private void InputComplete()
    {
        gc.DisplayLoggedText();
        inputField.ActivateInputField();
        inputField.text = null;
    }
}
