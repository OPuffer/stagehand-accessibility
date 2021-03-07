using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class MadLibScript : MonoBehaviour
{
    private String script;

    #region Inspector Variables
    [SerializeField]
    private TextMeshProUGUI hintText;
    #endregion

    String LoadMadLibData()
    {
        // I'm so sorry.
        List<List<String>> scripts = new List<List<string>>();
        scripts.Add(new List<string>());
        
        
        int lib = Random.Range(0, 5);
        
        GameManager gm = GameManager.instance;
        //gm.gameState
    }
    
    String GetCurrentHint()
    {
        return "";
    }

    // Start is called before the first frame update
    void Start()
    {
        hint_text.text = GetCurrentHint();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
