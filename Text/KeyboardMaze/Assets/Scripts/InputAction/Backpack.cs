﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "KeyboardMaze/InputAction/Backpack")]
public class Backpack : InputAction
{
    // Start is called before the first frame update
    //void Start(){}

    // Update is called once per frame
    //void Update(){}

    public override void RespondToInput(GameController gc, string[] separatedInputWords)
    {
        gc.im.DisplayInventory();
    }
}
