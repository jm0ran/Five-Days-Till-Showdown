using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

public class movement : MonoBehaviour
{
    //set of variable used for the movement
    public Transform forward;
    public Transform back;
    public Tilemap tilemap;
    // Update is called once per frame
    void Update()
    {
        gridMovement();//the movement function call that runs every frame
    }
    void gridMovement()//the movement function that houses all the data used for the movement of the player object
    {
        interaction interaction = gameObject.GetComponent<interaction>();
        Vector3 savePosF = new Vector3(forward.position.x, forward.position.y, 0);//stores the position of the front movePoint
        Vector3 savePosb = new Vector3(back.position.x, back.position.y, 0);//stores the position of the back movePoint

        if (interaction.noInput == false)//checks to see that dialogue isn't active
        {
            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))//checks for input from D or right arrow
            {
                Vector3Int gridPos = tilemap.WorldToCell(new Vector3(transform.position.x, transform.position.y, 0));//gets the grid position from the world and converts it to the tilemap grid position
                if (gridPos.y > -17)//checks to see if the y value of the player is greater than the fartherest value the player can go to the right
                {
                    transform.position = new Vector3(forward.position.x + 0.5f, forward.position.y, 0);//moves the player's position
                    forward.position = new Vector3(savePosF.x + 0.5f, savePosF.y - 0.25f, 0);//moves the front movePoint 
                    back.position = new Vector3(savePosb.x + 0.5f, savePosb.y - 0.25f, 0);//moves the back movePoint
                }
            }
        }
        if (interaction.noInput == false)//checks to see that dialogue isn't active
        {
            if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))//checks for input from D or down arrow
            {
                Vector3Int gridPos = tilemap.WorldToCell(new Vector3(transform.position.x, transform.position.y, 0));//gets the grid position from the world and converts it to the tilemap grid position
                if (gridPos.x > -3)//checks to see if the x value of the player is greater than the fartherest value the player can go down
                {
                    transform.position = new Vector3(forward.position.x - 0.5f, forward.position.y, 0);//moves the player position
                    forward.position = new Vector3(savePosF.x - 0.5f, savePosF.y - 0.25f, 0);//moves the front movePoint
                    back.position = new Vector3(savePosb.x - 0.5f, savePosb.y - 0.25f, 0);//moves the back Movepoint
                }
            }
        }
        if (interaction.noInput == false)//checks to see that dialogue isn't active
        {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))//checks for input from the W or up arrow
            {
                Vector3Int gridPos = tilemap.WorldToCell(new Vector3(transform.position.x, transform.position.y, 0));//gets the grid position from the world and converts it to the tilemap grid position
                if (gridPos.x < 7)//checks to see if the x value of the player is less than the highest value the player can go up
                {
                    transform.position = new Vector3(back.position.x + 0.5f, back.position.y, 0);//moves the player position
                    forward.position = new Vector3(savePosF.x + 0.5f, savePosF.y + 0.25f, 0);//moves the front movePoint
                    back.position = new Vector3(savePosb.x + 0.5f, savePosb.y + 0.25f, 0);//moves the back movePoint
                }
            }
        }
        if (interaction.noInput == false)//checks to see that dialogue isn't active
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))//checks for input from the A or left arrow
            {
                Vector3Int gridPos = tilemap.WorldToCell(new Vector3(transform.position.x, transform.position.y, 0));//gets the grid position from the world and converts it to the tilemap grid position
                if (gridPos.y < 8)//checks to see if the y value of the player is less than the highest value the player can go to the left
                {
                    transform.position = new Vector3(back.position.x - 0.5f, back.position.y, 0);//moves the player position
                    forward.position = new Vector3(savePosF.x - 0.5f, savePosF.y + 0.25f, 0);//moves the front movePoint
                    back.position = new Vector3(savePosb.x - 0.5f, savePosb.y + 0.25f, 0);//moves the back movePoint
                }
            }
        }

    }
}
