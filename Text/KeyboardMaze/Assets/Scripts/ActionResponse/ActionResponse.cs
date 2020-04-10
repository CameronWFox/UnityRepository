using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActionResponse : ScriptableObject
{
    // Start is called before the first frame update
    //void Start(){}

    // Update is called once per frame
    //void Update(){}

    public string actionResponseString; //String key that is used to check if an action response is allowed to occur

    public abstract bool DoActionResponse(GameController gc); //Overrides method for all action responses
}
