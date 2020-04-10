using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stat
{
    [SerializeField]
    private int baseValue; // Base value of a given stat.

    private List<int> statModifiers = new List<int>();

    public int GetValue()
    {
        int finalValue = baseValue;
        statModifiers.ForEach(x => finalValue += x);
        return finalValue;
    }

    public void AddModifier(int statModifier)
    {
        if (statModifier != 0)
        {
            statModifiers.Add(statModifier);
        }
    }

    public void RemoveModifier(int statModifier)
    {
        if (statModifier != 0)
        {
            statModifiers.Remove(statModifier);
        }
    }
}
