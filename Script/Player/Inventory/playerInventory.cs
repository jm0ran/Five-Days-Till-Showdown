using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Player
{
    public class playerInventory : MonoBehaviour
    {
        List<string> inventory = new List<string>();//future use for viewing items obtained

        // Update is called once per frame
        void Update()
        {
        
        }

        public void looting(string newWeapon)//make it so that you can't move when action is true and set a small time to open the chest
        {
            inventory.Add(newWeapon);//adds weapon from chest to player inventory
        }
    }
}
