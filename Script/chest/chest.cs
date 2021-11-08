using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

/*New Game plan
-Create 4 jsons for each chest loot pool
-create a class that can access each file based on the tag attached to it
-work on the loot drop system and storing it in the player inventory for later use
 */
public class chest : MonoBehaviour
{
    public weaponPool firearms = new weaponPool();//instance of weapon pool class
    public weaponPool melee = new weaponPool();
    public weaponPool goku = new weaponPool();
    public weaponPool consumable = new weaponPool();
    public drop drop = new drop();

    void Start()
    {
        //set of four weapons that I generated
        firearms.newWeapon("M4","firearm",8,60);
        firearms.newWeapon("Pistol", "firearm", 3, 90);
        melee.newWeapon("bat", "melee", 6, 80);
        goku.newWeapon("goku gun", "goku", 20, 2);
        consumable.newWeapon("sushi", "consumable", 15, 50);
        consumable.newWeapon("pizza", "consumable", 10, 30);
        consumable.newWeapon("ramen", "consumable", 20, 15);
        consumable.newWeapon("steak", "consumable", 25, 5);
        File.WriteAllText(Path.Combine(Application.streamingAssetsPath, "firearms.json"), JsonUtility.ToJson(firearms));
        File.WriteAllText(Path.Combine(Application.streamingAssetsPath, "melee.json"), JsonUtility.ToJson(melee));
        File.WriteAllText(Path.Combine(Application.streamingAssetsPath, "goku.json"), JsonUtility.ToJson(goku));
        File.WriteAllText(Path.Combine(Application.streamingAssetsPath, "consumable.json"), JsonUtility.ToJson(consumable));
        //Debug.Log(JsonUtility.FromJson<weaponPool>(File.ReadAllText("testing.json"))); Test to see if the code worked
    }
}
