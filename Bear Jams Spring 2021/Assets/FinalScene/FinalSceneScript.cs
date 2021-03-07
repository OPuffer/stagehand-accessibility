using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using TMPro;
using UnityEngine;

public class FinalSceneScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI tempTbox;

    private int currentLine = 0;
    private List<String> script;

    void ShowNextLine()
    {
        if (currentLine < script.Count)
        {
            // Stop wobbling the old puppet.
            GameManager.instance.gameState.socks[currentLine % GameManager.instance.gameState.numberOfSocks]
                .GetComponent<Animator>().Play("Nothing");
            
            // Set the new text and start wobbling the new puppet.
            Debug.Log(script);
            Debug.Log(currentLine);
            Debug.Log(tempTbox);
            tempTbox.SetText(script[currentLine]);
            GameManager.instance.gameState.socks[currentLine % GameManager.instance.gameState.numberOfSocks]
                .GetComponent<Animator>().Play("PuppetWobble");
            
            // Increment line counter.
            currentLine += 1;
        }
        else
        {
            // Game's done.
            GameManager.instance.LoadMain();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        script = GameManager.instance.gameState.script;
        
        foreach (GameObject sock in GameManager.instance.gameState.socks)
        {
            //sock.GetComponent<SpriteRenderer>().enabled = true;
            foreach (SpriteRenderer sr in sock.GetComponentsInChildren<SpriteRenderer>()) {
                sr.enabled = true;
            }
        }

        ShowNextLine();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            ShowNextLine();
        }
    }
}
