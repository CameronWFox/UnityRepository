using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEquipmentChanged (Equipment newEquipment, Equipment oldEquipment)
    {
        if (newEquipment != null)
        {
            //armor.AddModifier(newEquipment.armorModifier);
            //damage.AddModifier(newEquipment.damageModifier);
        }

        if (oldEquipment != null)
        {
            //armor.RemoveModifier(oldEquipment.armorModifier);
            //damage.RemoveModifier(oldEquipment.damageModifier);
        }

        
    }

    public override void Die()
    {
        base.Die();
        //PlayerController.instance.KillPlayer();
    }
}
