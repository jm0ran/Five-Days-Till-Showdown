using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestController : MonoBehaviour
{
    private drop drop = new drop();
    public string weaponName;
    void Start() 
    {
        chest();
    }
    void chest()
    {
        if(gameObject.tag == "consumable")
        {
            drop.randomValue();
           weaponName = drop.dropped("consumable.json",4);
        }

        if(gameObject.tag == "firearms")
        {
            drop.randomValue();
            weaponName = drop.dropped("firearms.json",4);
        }
        
        if(gameObject.tag == "melee")
        {
            drop.randomValue();
            weaponName = drop.dropped("melee.json",6);
        }

        if(gameObject.tag == "goku")
        {
           drop.randomValue();
           weaponName = drop.dropped("goku.json",7);
        }
    }
}
