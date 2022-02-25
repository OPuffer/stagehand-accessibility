using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssemblyItem : MonoBehaviour
{

    public Image itemImage;
    public Text itemText;
    
    [Header("Configs, don't edit")]
    public int index;
    
    public void Select()
    {
        AssemblyPanel.instance.Select(this.index);
    }
    
}
