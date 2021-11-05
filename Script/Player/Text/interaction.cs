using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction : MonoBehaviour
{
    public bool noInput = false;
    public Canvas canvas;
    // Update is called once per frame
    void Update()
    {
        Canvas render = canvas.GetComponent<Canvas>();
        if (render.enabled == true)
        {
            noInput = true;
        }
        if (render.enabled == true && Input.GetKeyDown(KeyCode.E))
        {
            noInput = false;
            render.enabled = false;
            Debug.Log("Working");

        }
    }
}
