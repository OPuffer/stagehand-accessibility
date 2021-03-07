using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSelector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //set number of socks to be a random number of socks
        GameManager.instance.gameState.numberOfSocks = Random.Range(1, 3);
    }
}
