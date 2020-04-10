using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InputAction : ScriptableObject
{
    public string actionKeyWord; //Input word that the InputAction script will respond to

    public abstract void RespondToInput(GameController gc, string[] separatedInputWords); //Method that will respond to text input from the user
}
