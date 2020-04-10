using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Interaction
{
    // Start is called before the first frame update
    //void Start(){}

    // Update is called once per frame
    //void Update(){}

    public InputAction inputActionInteraction; //Result that occurs from a specific input action

    [TextArea]
    public string textResponse; //Text area for a response from trying to interact with something

    public ActionResponse actionResponse;
}
