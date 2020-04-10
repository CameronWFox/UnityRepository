using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : Item
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public EquipmentSlot equipmentSlot;

    public int damageModifier;
    public int armorModifier;

    public override void Use()
    {
        base.Use();
        //EquipmentManager.instance.Equip(this);
        RemoveFromInventory();
    }
}

public enum EquipmentSlot { Head, Chest, Arms, Legs, Hands, Feet, Sheild, Weapon, Ammo }
