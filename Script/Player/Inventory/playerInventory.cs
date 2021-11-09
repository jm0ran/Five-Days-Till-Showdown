using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInventory : MonoBehaviour
{
    public List<string> inventory = new List<string>();//future use for viewing items obtained

    public void insertInventory(string itemName)
    {
        inventory.Add(itemName);
        Debug.Log(itemName);
    }
}

