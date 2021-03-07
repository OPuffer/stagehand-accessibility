using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using TMPro;
using UnityEngine;

public class FinalSceneScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI tempTbox;
    
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject sock in GameManager.instance.gameState.socks)
        {
            // TODO: Show socks somehow?
        }

        foreach (String line in GameManager.instance.gameState.script)
        {
            tempTbox.text = tempTbox.text + line;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
