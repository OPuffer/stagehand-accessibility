using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public GameState gameState = new GameState();

    void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public void LoadMain()
    {
        
    }

    public void LoadTutorial()
    {
        
    }


    public void LoadAssembly()
    {
        
    }

    public void LoadScriptWriter()
    {
        
    }

    public void LoadFinal()
    {
        
    }
    
    
}
