using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detector : MonoBehaviour
{
    public bool inRange;
    public string weaponName;
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
                Debug.Log(weaponName = gameObject.GetComponent<chestController>().weaponName); 
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
}
