using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.IO;

public class drop
{
    public int random;
    public string file;
    public List<int> rates;
    public List<string> weaponName;
    public drop()
    {
        random = 0;
        rates = new List<int>();
        weaponName = new List<string>(); 
    }
    public void randomValue()
    {
        random = UnityEngine.Random.Range(0, 100);
    }
    public string dropped(string fileName, int jsonSize)
    {
        file = File.ReadAllText(Path.Combine(Application.streamingAssetsPath, fileName));
        for (int i = 0; i < 4; i++)
        {
            rates.Add(JsonUtility.FromJson<weaponPool>(file).pool[i].weight);
            weaponName.Add(JsonUtility.FromJson<weaponPool>(file).pool[i].weaponName);
        }
        for(int j = 0; j < 4; j++)
        {
            if (random <= rates[j])
            {
                return weaponName[j];
            }
            else
            {
                random -= rates[j];
            }
        }
        return null;
    }
}

