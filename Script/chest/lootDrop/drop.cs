using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.IO;

/*Rules for creating weighted table
 * 1. Everything in the table combined must equal up to 100 or 1000
 * 2. Create a random value in a range between 0 and the tallied weight(100 or 1000)
 * 3. Use for each statement to check what weapon the player pulled
 * 4. 

 */
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
        Debug.Log(random);
    }
    public void dropped(string fileName)
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
                Debug.Log(weaponName[j]);
                break;
            }
            else
            {
                random -= rates[j];
            }
        }
    }
}

