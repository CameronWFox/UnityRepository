using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton
    public static Inventory instance; // Instance varialbe for the Inventory Script
    public List<Item> itemList = new List<Item>(); // List of Items

    void Awake()
    {
        if (instance != null)
        {
            Debug.Log("More than one instance of inventory found.");
            return;
        }
        instance = this;
    }
    #endregion

    public delegate void onItemChanged();
    public onItemChanged onItemChangedCallBack;

    public int inventorySpace = 15; // Avaliable space for the player inventory.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool Add(Item newItem)
    {
        if (!newItem.isDefaultItem)
        {
            if (itemList.Count >= inventorySpace)
            {
                Debug.Log("Not Enough Space in Inventory.");
                return false;
            }
            itemList.Add(newItem);

            if (onItemChangedCallBack != null)
            {
                onItemChangedCallBack.Invoke();
            }
        }
        return true;
    }

    public void Remove(Item oldItem)
    {
        itemList.Remove(oldItem);

        if (onItemChangedCallBack != null)
        {
            onItemChangedCallBack.Invoke();
        }
    }
}
