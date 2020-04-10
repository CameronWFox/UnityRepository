using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "KeyboardMaze/InputAction/Examine")]
public class Examine : InputAction
{
    // Start is called before the first frame update
    //void Start(){}

    // Update is called once per frame
    //void Update(){}

    public override void RespondToInput(GameController gc, string[] separatedInputWords)
    {
        gc.LogStringInputWithReturn(gc.TestVerbDictionaryWithNoun(gc.im.examineDictionary, separatedInputWords[0], separatedInputWords[1]));
    }
}
