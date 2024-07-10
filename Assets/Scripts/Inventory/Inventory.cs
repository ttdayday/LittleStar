using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory: ScriptableObject
{
    public List<InventoryItem> Container = new List<InventoryItem>();


}

[System.Serializable]
public class InventorySlot
{
    public InventoryItem item;
    public int amount;
    public InventorySlot(InventoryItem _item, int _amount)
    { }
}


