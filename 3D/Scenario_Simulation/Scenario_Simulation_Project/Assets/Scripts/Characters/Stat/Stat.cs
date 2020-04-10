using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stat
{
    [SerializeField]
    private int base_value; //Base number for a given stat;

    private List<int> stat_modifiers = new List<int>(); //List of all created stat modifiers;

    // Returns the current value of a specific stat;
    public int GetValue()
    {
        int final_value = base_value;
        stat_modifiers.ForEach(x => final_value += x);
        return final_value;
    }

    // Adds a new stat modifier to the list;
    public void AddModifier(int stat_modifier)
    {
        if (stat_modifier != 0)
        {
            stat_modifiers.Add(stat_modifier);
        }
    }

    // Removes a current stat modifier from the list;
    public void RemoveModifier(int stat_modifier)
    {
        if (stat_modifier != 0)
        {
            stat_modifiers.Remove(stat_modifier);
        }
    }
}
