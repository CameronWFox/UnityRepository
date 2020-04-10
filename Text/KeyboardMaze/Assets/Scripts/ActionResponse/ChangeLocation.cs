using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "KeyboardMaze/ActionResponse/ChangeLocation")]
public class ChangeLocation : ActionResponse
{
    // Start is called before the first frame update
    //void Start(){}

    // Update is called once per frame
    //void Update(){}

    public Location locationToChangeTo;

    public override bool DoActionResponse(GameController gc)
    {
        if (gc.navigation.currentLocation.locationName == actionResponseString)
        {
            gc.navigation.currentLocation = locationToChangeTo;
            gc.DisplayLocationText();
            return true;
        }
        return false;
    }
}
