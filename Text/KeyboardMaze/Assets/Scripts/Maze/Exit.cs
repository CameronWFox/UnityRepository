using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Exit
{
    // Start is called before the first frame update
    //void Start(){}

    // Update is called once per frame
    //void Update(){}

    public string exitKeyString; //The key string used for each individual exit

    public string exitDescription; //Description of an exit leading from the current location

    public Location locationValue; //Check to see which exit from the current location is beign used, if there is more than just one exit out of the current location
}
