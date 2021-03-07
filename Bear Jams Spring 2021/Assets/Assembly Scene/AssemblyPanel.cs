using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssemblyPanel : MonoBehaviour
{

    public static AssemblyPanel instance;
    
    #region Inspector Variables

    [SerializeField]
    [Tooltip("All available items for assembly")]
    private List<FeatureList> m_items;

    [SerializeField] [Tooltip("Item bucket prefab")]
    private GameObject m_itemBucket;

    [SerializeField] private Transform grid;
    
    #endregion

    #region Wrapper classes

    [Serializable]
    public class Item
    {

        [SerializeField] public String name;

        [SerializeField] [Tooltip("The sprite to be used on the puppet")] 
        public Sprite m_PuppetSprite;

        [SerializeField] [Tooltip("The image to be used in the panel")]
        public Sprite m_PanelImage;

    }

    [Serializable]
    public class FeatureList
    {
        [SerializeField] private string name;
        public List<Item> featureList;
    }
    
    #endregion

    #region Cached Values

    private GameObject cr_Sock;

    #endregion

    #region Private Variables

    private int p_selected;
    public int Selected
    {
        get
        {
            return p_selected;
        }
        set
        {
            p_selected = value;
        }
    }

    private int p_FeatureIndex;

    #endregion
    
    #region Instantiation

    void Start()
    {

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        cr_Sock = GameObject.FindWithTag("Sock");
        this.p_selected = 0;
        this.p_FeatureIndex = 0;
        //create the items in the panel
        Clear();
        Fill();
    }
    

    #endregion

    #region Select Methods

    public void Select(int index)
    {
        this.p_selected = index;
        GameObject featurePrefab = cr_Sock.GetComponent<SockController>().featurePrefabs[p_FeatureIndex];
        featurePrefab.GetComponent<SpriteRenderer>().sprite = m_items[p_FeatureIndex].featureList[index].m_PuppetSprite;
        
    }

    public void SelectFeature(int index)
    {
        p_FeatureIndex = index;
        Clear();
        Fill();
    }

    #endregion
    
    #region Clear and Fill methods

    public void Clear()
    {
        for (int i = 0; i < grid.childCount; i++)
        {
            Destroy(grid.GetChild(i).gameObject);
        }   
    }
    
    void Fill()
    {
        List<Item> items = m_items[p_FeatureIndex].featureList;
        for (int i = 0; i < items.Count; i++)
        {
            GameObject itemBucket = Instantiate(m_itemBucket, grid, false);
            AssemblyItem script = itemBucket.GetComponent<AssemblyItem>();
            script.itemImage.sprite = items[i].m_PanelImage;
            script.index = i;
        }
    }

    #endregion

    #region Save method

    public void Save()
    {
        DontDestroyOnLoad(cr_Sock);
        GameState gs = GameManager.instance.gameState;
        gs.socks.Add(cr_Sock);
        if (gs.socks.Count == gs.numberOfSocks)
        {
            GameManager.instance.LoadScriptWriter();
        }
        else
        {
            GameManager.instance.LoadAssembly();
        }
    }

    #endregion
    
}
