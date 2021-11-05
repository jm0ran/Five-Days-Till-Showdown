using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class weaponPool
{
    public List<weapon> pool;
    public weaponPool()
    {
        pool = new List<weapon>();
    }

    public void newWeapon(string name, string type, int dmg, int weight)
    {
        weapon newWeapon = new weapon(name, type, dmg, weight);
        pool.Add(newWeapon);
    }
}
