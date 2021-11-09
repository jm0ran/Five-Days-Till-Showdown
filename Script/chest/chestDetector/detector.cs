using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detector : MonoBehaviour
{
    public bool inRange;
    public GameObject player;
    private string weaponName;
    void Update()
    {
        playerInRange();
    }
    void playerInRange()
    {
        if(inRange)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                player.GetComponent<playerInventory>().insertInventory(gameObject.GetComponent<chestController>().weaponName); 
                Destroy(gameObject);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            inRange = true;
        }
    }
        void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            inRange = false;
        }
    }
}
