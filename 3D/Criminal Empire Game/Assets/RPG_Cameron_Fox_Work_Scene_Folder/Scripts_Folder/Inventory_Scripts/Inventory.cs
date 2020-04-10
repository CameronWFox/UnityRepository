using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton
    public static Inventory instance;

    public List<Item> items = new List<Item>(); // List of items

    private void Awake()
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
    public onItemChanged onItemChangedCallback;

    public int inventorySpace = 20;

    // Use this for initialization
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
            if (items.Count >= inventorySpace)
            {
                Debug.Log("Not enough space in inventory.");
                return false;
            }
            items.Add(newItem);

            if (onItemChangedCallback != null)
            {
                onItemChangedCallback.Invoke();
            }
        }
        return true;
    }

    public void Remove(Item oldItem)
    {
        items.Remove(oldItem);

        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
    }
}
