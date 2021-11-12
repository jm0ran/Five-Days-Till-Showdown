using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie
{
    float biteDmg;
    float scratchDmg;
    int chanceToCrit;
    int health;
    int speed;
    int evasion;
    int random;

    public zombie()
    {
        biteDmg = 5f;
        scratchDmg = 3f;
        chanceToCrit = 2;
        health = 10;
        speed = 4;
        evasion = 10;
    }

    public void bite()
    {
        random = UnityEngine.Random.Range(0, 10);
        if(random <= chanceToCrit)
        {
            biteDmg *= 1.5f;
        }
    }
    public void scratch()
    {
        random = UnityEngine.Random.Range(0, 10);
        if(random <= chanceToCrit)
        {
            biteDmg *= 1.7f;
        }
    }

    public void dmgTaken(int dmg)
    {
        health -= dmg;
    }
}
