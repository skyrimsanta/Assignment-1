using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* (Levi Schoof)
* (Bow)
* (Assignment 1)
* (Implaments the Bow Interface)
*/

public class Bow : Weapon, BowInterface
{
    int fireDamage;
    public void Aim()
    {
        Debug.Log("Jim Aims his Fire Bow");
    }

    public override void Breaks()
    {
        Debug.Log("Jim's Fire Bow Breaks");
    }

    public void SetFireDamage(int dam){ fireDamage = dam; }

}
