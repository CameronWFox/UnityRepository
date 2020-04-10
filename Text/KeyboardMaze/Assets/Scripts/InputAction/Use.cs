using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "KeyboardMaze/InputAction/Use")]
public class Use : InputAction
{
    // Start is called before the first frame update
    //void Start(){}

    // Update is called once per frame
    //void Update(){}

    public override void RespondToInput(GameController gc, string[] separatedInputWords)
    {
        gc.im.UseInteractable(separatedInputWords);
    }
}
