using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    public List<InventoryItem> items = new List<InventoryItem>();
    public UnityEvent onItemChanged;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found!");
            return;
        }
        instance = this;
    }

    public void Add(InventoryItem item)
    {
        items.Add(item);
        onItemChanged.Invoke();
    }

    public void Remove(InventoryItem item)
    {
        items.Remove(item);
        onItemChanged.Invoke();
    }
}
