using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text textDisplay; //Text Display Object
    public InputAction[] inputActions; //InputAction Object Array of all keyboard input actions
    //public InputAction[] menuActions; //InputAction Object Array of all the keyboard input actions for menu navigation

    List<string> actionLog = new List<string>(); //Log of all actions that have taken place

    [HideInInspector] public Navigation navigation; //Navigation Object
    [HideInInspector] public InteractableManager im; //InteractableManager Object
    [HideInInspector] public List<string> interactionDescriptionInLocation = new List<string>(); //List of all the interaction descriptions that take place in current location

    void Awake()
    {
        navigation = GetComponent<Navigation>(); //Reference to the Navigation script
        im = GetComponent<InteractableManager>(); //Reference to the InteractableManager script
    }
    // Start is called before the first frame update
    void Start()
    {
        DisplayLocationText();
        DisplayLoggedText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayLoggedText()
    {
        string logAsText = string.Join("\n", actionLog.ToArray());
        textDisplay.text = logAsText;
    }

    public void DisplayLocationText()
    {
        ClearCollectionsForNewLocation();
        UnpackCurrentLocation();

        if (navigation.pastLocationList.Contains(navigation.currentLocation.locationName))
        {
            LogStringInputWithReturn("You recall entering this area before..." + "\n" + "You know where you need to go from here right?...I hope...");
        }
        else
        {
            navigation.pastLocationList.Add(navigation.currentLocation.locationName);

            string joinedInteractionDescriptions = string.Join("\n", interactionDescriptionInLocation.ToArray());
            string combinedText = navigation.currentLocation.locationDescription + "\n" + joinedInteractionDescriptions;

            LogStringInputWithReturn(combinedText);
        }
    }

    private void UnpackCurrentLocation()
    {
        navigation.UnpackLocationExits(); //Unpacks the exits for the current location
        PrepareInteractableInLocationForTakeExamineDrop(navigation.currentLocation); //Prepares any an dall interactable objects in the current location
    }

    private void PrepareInteractableInLocationForTakeExamineDrop(Location currentLocation)
    {
        for (int i = 0; i < currentLocation.locationInteractableObjects.Length; i++)
        {
            string interactableDescriptionNotInInventory = im.GetLocationInteractableNotInInventory(currentLocation, i);

            if (interactableDescriptionNotInInventory != null)
            {
                interactionDescriptionInLocation.Add(interactableDescriptionNotInInventory);
            }
            Interactable interactable = currentLocation.locationInteractableObjects[i];

            for (int j = 0; j < interactable.interactions.Length; j++)
            {
                Interaction interaction = interactable.interactions[j];

                if (interaction.inputActionInteraction.actionKeyWord == "examine")
                {
                    im.examineDictionary.Add(interactable.noun, interaction.textResponse);
                }

                if (interaction.inputActionInteraction.actionKeyWord == "take")
                {
                    im.takeDictionary.Add(interactable.noun, interaction.textResponse);
                }

                if (interaction.inputActionInteraction.actionKeyWord == "drop")
                {
                    //Remove interactable from inventory
                    //add it to the array of interactable objects in the current room
                    LogStringInputWithReturn("You dropped the interactable, it is never seen again...");
                }
            }
        }
    }

    public string TestVerbDictionaryWithNoun(Dictionary<string, string> verbDictionary, string verb, string noun)
    {
        if (verbDictionary.ContainsKey(noun))
        {
            return verbDictionary[noun];
        }
        return "You cannot " + verb + " " + noun + ".";
    }

    //public string TestMenuList(List<string> menuActionList, string noun)
    //{
    //if (menuActionList.Contains(noun))
    //{
    //return noun;
    //}
    //return noun + " Is not a correct command, please try again.";
    //}

    private void ClearCollectionsForNewLocation()
    {
        im.ClearCollections();
        interactionDescriptionInLocation.Clear();
        navigation.ClearLocationExits();
    }

    public void LogStringInputWithReturn(string stringToAdd)
    {
        actionLog.Add(stringToAdd + "\n"); //Adds the new string to the action log
    }
}
