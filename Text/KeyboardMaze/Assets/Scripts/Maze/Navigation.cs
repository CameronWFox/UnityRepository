using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    GameController gc; //GameController Object

    public Location currentLocation; //Location Object

    [HideInInspector] public List<string> pastLocationList = new List<string>(); //List of all past locations the user has been to, used for backtracking

    Dictionary<string, Location> locationExitDictionary = new Dictionary<string, Location>(); //Dictionary for all the avaliable exits from the user's current location
    private void Awake()
    {
        gc = GetComponent<GameController>(); //Reference to the GameController script
    }

    // Start is called before the first frame update
    //void Start(){}

    // Update is called once per frame
    //void Update(){}

    public void UnpackLocationExits()
    {
        for (int i = 0; i < currentLocation.locationExits.Length; i++)
        {
            locationExitDictionary.Add(currentLocation.locationExits[i].exitKeyString, currentLocation.locationExits[i].locationValue);

            gc.interactionDescriptionInLocation.Add(currentLocation.locationExits[i].exitDescription);
        }
    }

    public void AttemptToExitLocation(string directionNoun)
    {
        if (locationExitDictionary.ContainsKey(directionNoun))
        {
            currentLocation = locationExitDictionary[directionNoun];

            gc.LogStringInputWithReturn("You head " + directionNoun + ".");
            gc.DisplayLocationText();
        }
        else
        {
            gc.LogStringInputWithReturn("There is no path leading " + directionNoun + ".");
        }
    }

    public void ClearLocationExits()
    {
        locationExitDictionary.Clear();
    }
}
