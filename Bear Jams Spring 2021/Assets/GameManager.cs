using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        GameManager.instance.gameState.numberOfSocks = Random.Range(1, 3);
    }

    
    
    public void LoadMain()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadAssembly()
    {
        SceneManager.LoadScene("Assembly");
    }

    public void LoadScriptWriter()
    {
        SceneManager.LoadScene("MadLibScene");
    }

    public void LoadFinal()
    {
        SceneManager.LoadScene("FinalScene");
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }
    
}
