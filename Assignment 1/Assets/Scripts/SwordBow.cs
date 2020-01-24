using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* (Levi Schoof)
* (Sword Bow)
* (Assignment 1)
* (A class that fills out the Weapon, Bow, and Sword it inherits from)
*/

public class SwordBow : Weapon, BowInterface, SwordInterface
{
    public override void Breaks()
    {
        Debug.Log("Jim's Sword bow breaks");
    }

    public void Swing()
    {
        Debug.Log("Jim Swings the Sword Bow");
    }

    void BowInterface.Aim()
    {
        Debug.Log("Jim Aims the Sword Bow");
    }
}
