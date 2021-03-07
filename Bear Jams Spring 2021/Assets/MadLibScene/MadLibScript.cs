using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class MadLibScript : MonoBehaviour
{
    private String currentHint;
    
    #region Inspector Variables
    [SerializeField]
    private TextMeshProUGUI hintText;

    [SerializeField]
    private TMP_InputField inputField;
    #endregion
    
    List<String> GetMadLib(int numPuppets)
    {
        // I'm so sorry.
        List<List<String>> selectedScripts = Script.scripts[numPuppets - 1];
        List<String> randomScript = selectedScripts[Random.Range(0, selectedScripts.Count)];

        return randomScript;
    }

    #region Current Hint Methods

    String GetCurrentHint()
    {
        GameManager gm = GameManager.instance;

        // Assumes well-formatted strings, UB otherwise.
        foreach (String line in gm.gameState.script)
        {
            int idx = line.IndexOf("[");
            if (idx != -1)
            {
                int idx_end = line.IndexOf("]");
                currentHint = line.Substring(idx, idx_end-idx+1);
                return currentHint;
            }
        }

        currentHint = "";
        return "";
    }

    void SetCurrentHint(String replacement)
    {
        GameManager gm = GameManager.instance;
        
        // Assumes well-formatted strings, UB otherwise.
        for (int i = 0; i < gm.gameState.script.Count; i++)
        {
            int idx = gm.gameState.script[i].IndexOf("[");
            if (idx != -1)
            {
                var regex = new Regex(Regex.Escape(currentHint));
                gm.gameState.script[i] = regex.Replace(gm.gameState.script[i], replacement, 1);
            }
        }
    }

    #endregion

    #region UI Methods

    public void OnClickNext()
    {
        String replacement = inputField.text;
        SetCurrentHint(replacement);
        GetCurrentHint();
        if (currentHint == "")
        {
            GameManager gm = GameManager.instance;
            gm.LoadFinal();
        }
        else
        {
            hintText.text = currentHint;
            inputField.text = "";
        }
    }

    #endregion

    #region Instantiation Methods

    void Start()
    {
        GameManager gm = GameManager.instance;
        // TODO: Make sure this is set in a previous scene!
        gm.gameState.numberOfSocks = 1;
        gm.gameState.script = GetMadLib(gm.gameState.numberOfSocks);
        
        hintText.text = GetCurrentHint();
    }

    #endregion
    
}
