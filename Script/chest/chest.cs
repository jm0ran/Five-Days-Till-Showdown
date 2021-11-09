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
        firearms.newWeapon("Makorov","firearm",3, 40);
        firearms.newWeapon("M1911", "firearm", 4, 30);
        firearms.newWeapon("Remmington","firearm",8,20);
        firearms.newWeapon("Hunting Rifle","firearm",10,10);

        melee.newWeapon("Bat", "melee", 8,25);
        melee.newWeapon("Crowbar", "melee", 7,20);
        melee.newWeapon("Knife", "melee", 5,18);
        melee.newWeapon("Cleaver", "melee", 6,15);
        melee.newWeapon("Axe", "melee", 9,12);
        melee.newWeapon("Katana", "melee", 12,10);

        goku.newWeapon("bat", "goku", 20, 50);
        goku.newWeapon("makorov", "goku", 20, 22);
        goku.newWeapon("Goku Bat", "goku", 20, 10);
        goku.newWeapon("Vegeta Pistol", "goku", 20, 6);
        goku.newWeapon("Vegeta Bat", "goku", 20, 5);
        goku.newWeapon("Goku Pistol", "goku", 20,4);
        goku.newWeapon("Piccolo Bat", "goku", 20, 3);

        consumable.newWeapon("sushi", "consumable", 15, 50);
        consumable.newWeapon("pizza", "consumable", 10, 30);
        consumable.newWeapon("ramen", "consumable", 20, 15);
        consumable.newWeapon("steak", "consumable", 25, 5);

        File.WriteAllText(Path.Combine(Application.streamingAssetsPath, "firearms.json"), JsonUtility.ToJson(firearms));
        File.WriteAllText(Path.Combine(Application.streamingAssetsPath, "melee.json"), JsonUtility.ToJson(melee));
        File.WriteAllText(Path.Combine(Application.streamingAssetsPath, "goku.json"), JsonUtility.ToJson(goku));
        File.WriteAllText(Path.Combine(Application.streamingAssetsPath, "consumable.json"), JsonUtility.ToJson(consumable));
    }
}
