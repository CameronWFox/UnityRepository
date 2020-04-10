using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "KeyboardMaze/Maze/Location")]
public class Location : ScriptableObject
{
    // Start is called before the first frame update
    //void Start(){}

    // Update is called once per frame
    //void Update(){}

    public string locationName; //Name of the entered location

    [TextArea]
    public string locationDescription; //Description of the entered location

    public Exit[] locationExits; //An array of all the exits in the current location
    public Interactable[] locationInteractableObjects; //An array of all the interactable objects in the current location
    public Interaction[] locationInteractions; //An array of all the interactions that can occur in the current location
}
