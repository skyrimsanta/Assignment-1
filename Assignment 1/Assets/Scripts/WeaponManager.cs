using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
* (Levi Schoof)
* (Weapon Manager)
* (Assignment 1)
* (Creates and tests out the different weapon classes)
*/

public class WeaponManager : MonoBehaviour
{
    List<Weapon> weapons = new List<Weapon>();
    List<BowInterface> bows = new List<BowInterface>();
    // Start is called before the first frame update
    void Start()
    {
        weapons.Add(new Bow());
        weapons.Add(new Bow());

        weapons.Add(new Sword());
        weapons.Add(new Sword());
        weapons.Add(new SwordBow());

        for (int i = 0; i < 4; i++)
        {
            bows.Add(new Bow());
        }
        bows.Add(new SwordBow());

        Bow bow = new Bow();
        bow.SetDamage(1);
        bow.SetGoldValue(1);
        bow.SetFireDamage(1);
        bow.Aim();

        Sword sword = new Sword();
        sword.SetGoldValue(1);
        sword.SetDamage(1);
        sword.Swing();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach(Weapon w in weapons)
            {
                w.Breaks();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach(BowInterface bw in bows)
            {
                bw.Aim();
            }
        }
    }
}
