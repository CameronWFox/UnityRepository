using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int full_health = 100; // Total amount of healh points a character has;
    public int current_health { get; private set; } // The amount of health points a character currents has left;

    public Stat damage; // Damage stat;
    public Stat armor; // Armor stat;

    private void Awake()
    {
        current_health = full_health;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(10);
        }
    }

    // current_health is reduced as damage is taken and reduction will not go below zero;
    public void TakeDamage(int damage)
    {
        damage -= armor.GetValue();
        damage = Mathf.Clamp(damage, 0, int.MaxValue);

        current_health -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage.");

        if (current_health <= 0)
        {
            Die();
        }
    }

    // When current_health reaches zero;
    public virtual void Die()
    {
        // player die in some way
        // this is ment to be overridden
        Debug.Log(transform.name + " died.");
    }
}
