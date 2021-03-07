using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Play Button onClick
    public void DoPlayButton()
    {
        GameManager gm = GameManager.instance;
        gm.LoadAssembly();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
