using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "KeyboardMaze/InputAction/Take")]
public class Take : InputAction
{
    // Start is called before the first frame update
    //void Start(){}

    // Update is called once per frame
    //void Update(){}

    public override void RespondToInput(GameController gc, string[] separatedInputWords)
    {
        Dictionary<string, string> takeDictionary = new Dictionary<string, string>();
        gc.im.Take(separatedInputWords);

        if (takeDictionary != null)
        {
            gc.LogStringInputWithReturn(gc.TestVerbDictionaryWithNoun(takeDictionary, separatedInputWords[0], separatedInputWords[1]));
        }
    }
}
