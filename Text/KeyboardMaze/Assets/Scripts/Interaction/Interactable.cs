using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "KeyboardMaze/Interactable")] //Create an asset for creating new interactable objects
public class Interactable : ScriptableObject
{
    // Start is called before the first frame update
    //void Start(){}

    // Update is called once per frame
    //void Update(){}

    public string noun = "name"; //Name of the interactable

    [TextArea]
    public string locationDescription = "Description of the location of the noun";

    public Interaction[] interactions; //Array of all different interactions related to the interactable
}
