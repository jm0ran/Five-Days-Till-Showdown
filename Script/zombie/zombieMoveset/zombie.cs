using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie
{
    float biteDmg;
    int scratchDmg;
    int chanceToCrit;
    int random;
    int health;

    public zombie()
    {
        biteDmg = 5f;
        scratchDmg = 3;
        chanceToCrit = 2;
        health = 10;
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
}
