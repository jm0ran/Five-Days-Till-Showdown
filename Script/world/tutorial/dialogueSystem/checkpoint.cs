using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class checkpoint : MonoBehaviour
{
    public Transform player;
    public Canvas canvas;
    public Text dialogue;
    public string dialogueOutput;
    // Start is called before the first frame update
    void Start()
    {
        Canvas render = canvas.GetComponent<Canvas>();
        render.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position == transform.position && !Input.GetKeyDown(KeyCode.E))
        {
            Canvas render = canvas.GetComponent<Canvas>();
            render.enabled = true;
            dialogue.text = dialogueOutput;
        }
        if (player.position == transform.position && Input.GetKeyDown(KeyCode.E))
        {
            gameObject.SetActive(false);
        }
    }
}
