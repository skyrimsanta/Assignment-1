using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* (Levi Schoof)
* (Weapon)
* (Assignment 1)
* (An abstract class for every weapon)
*/

public abstract class Weapon
{
    double damage;
    double goldValue;

    public void SetDamage(double dam) { damage = dam; }
    public double GetDamage() { return damage; }

    public void SetGoldValue(double gold) { goldValue = gold; }
    public double GetGoldValue() { return goldValue; }
    public abstract void Breaks();
}
