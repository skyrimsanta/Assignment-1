using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* (Levi Schoof)
* (Sword)
* (Assignment 1)
* (Implaments the sword interface)
*/

public class Sword : Weapon, SwordInterface
{
    private int poisonDamage;

    public override void Breaks()
    {
        Debug.Log("Jim's Sword Breaks");
    }

    public void Swing()
    {
        Debug.Log("Jim Swung the Sword");
    }

    public void SetPoisonDamage(int dam)
    {
        poisonDamage = dam;
    }

}
