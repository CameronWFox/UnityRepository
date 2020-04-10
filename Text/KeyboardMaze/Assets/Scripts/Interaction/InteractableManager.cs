using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableManager : MonoBehaviour
{
    public static InteractableManager instance; //

    GameController gc; //GameController Object

    public List<Interactable> masterInteractableList = new List<Interactable>(); //Master list of all interactables in the game

    public Dictionary<string, string> examineDictionary = new Dictionary<string, string>(); //Dictionary for all the uses of the Examine input action
    public Dictionary<string, string> takeDictionary = new Dictionary<string, string>(); //Dictionary for all the uses of the Take input action
    public Dictionary<string, ActionResponse> useDictionary = new Dictionary<string, ActionResponse>(); //Dictionary for all the uses of Use input action

    [HideInInspector] public List<string> currentInteractableObjects = new List<string>(); //List of all interactables in at your current location

    List<string> interactableInInventory = new List<string>(); //List of all interactables in the player inventory

    //public List<string> menuActionList = new List<string>();

    private void Awake()
    {
        gc = GetComponent<GameController>();

        if (instance != null)
        {
            instance = this;
        }
    }

    //Check if an interactable is already in the inventory or not
    //If not in the inventory, place in the current room or hallway
    public string GetLocationInteractableNotInInventory(Location currentLocation, int i)
    {
        Interactable interactableInCurrentLocation = currentLocation.locationInteractableObjects[i];

        if (!interactableInInventory.Contains(interactableInCurrentLocation.noun))
        {
            currentInteractableObjects.Add(interactableInCurrentLocation.noun);
            return interactableInCurrentLocation.locationDescription;
        }

        return null;
    }

    // Displays all the interactables in the users inventory
    public void DisplayInventory()
    {
        gc.LogStringInputWithReturn("You look inside your backpack, inside you have: ");

        if (interactableInInventory.Count == 0) //Tests if inventory is already empty or not
        {
            gc.LogStringInputWithReturn("Nothing.");
        }

        for (int i = 0; i < interactableInInventory.Count; i++) //Prints out each item in the player's inventory
        {
            gc.LogStringInputWithReturn(interactableInInventory[i]);
        }
    }

    // when ever the user enters the take or use input action we add the action response to the useDictionary
    public void AddActionResponseToUseDictionary()
    {
        for (int i = 0; i < interactableInInventory.Count; i++)
        {
            string interactableName = interactableInInventory[i];

            Interactable interactableObjectInInventory = GetInteractableFromMasterInteractableList(interactableName);

            if (interactableObjectInInventory == null)
            {
                continue;
            }

            for (int j = 0; j < interactableObjectInInventory.interactions.Length; j++)
            {
                Interaction interaction = interactableObjectInInventory.interactions[j];

                if (interaction.actionResponse == null)
                {
                    continue;
                }

                if (!useDictionary.ContainsKey(interactableName))
                {
                    useDictionary.Add(interactableName, interaction.actionResponse);
                }
            }
        }
    }

    // If an interactable object matches with an item from the master list then return that item
    public Interactable GetInteractableFromMasterInteractableList(string objectName)
    {
        for (int i = 0; i < masterInteractableList.Count; i++)
        {
            if (masterInteractableList[i].noun == objectName)
            {
                return masterInteractableList[i];
            }
        }

        return null;
    }

    //
    public void ClearCollections()
    {
        examineDictionary.Clear();
        takeDictionary.Clear();
        currentInteractableObjects.Clear();
    }

    //
    public Dictionary<string, string> Take(string[] separatedInputWords)
    {
        if (currentInteractableObjects.Contains(separatedInputWords[1]))
        {
            interactableInInventory.Add(separatedInputWords[1]); //Adds noun/item string to inventory
            AddActionResponseToUseDictionary();
            currentInteractableObjects.Remove(separatedInputWords[1]); //Removes noun/item string from current room

            return takeDictionary;
        }
        else
        {
            gc.LogStringInputWithReturn("There is no " + separatedInputWords[1] + " here to take.");
            return null;
        }
    }

    //
    public void UseInteractable(string[] separatedInputWords)
    {
        string itemToUse = separatedInputWords[1];
        if (interactableInInventory.Contains(itemToUse))
        {
            if (useDictionary.ContainsKey(itemToUse))
            {
                bool actionResult = useDictionary[itemToUse].DoActionResponse(gc);

                if (!actionResult)
                {
                    gc.LogStringInputWithReturn("Hmm.. Nothing happens.");
                }
            }
            else
            {
                gc.LogStringInputWithReturn("You can't use the " + itemToUse + ".");
            }
        }
        else
        {
            gc.LogStringInputWithReturn("There is no " + itemToUse + " in your inventory.");
        }
    }
}
