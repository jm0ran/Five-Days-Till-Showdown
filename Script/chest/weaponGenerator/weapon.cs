using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.IO;

[System.Serializable]
public class weapon
{
    public string weaponName;
    public string damageType;
    public int damageValue;
    public int weight;

    public weapon(string iWeaponName, string iDamageType, int iDamageValue, int iWeight)
    {
        this.weaponName = iWeaponName;
        this.damageType = iDamageType;
        this.damageValue = iDamageValue;
        this.weight = iWeight;
    }
}

