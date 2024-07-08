using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Stuff Item", menuName = "Inventory/Item/Stuff")]

public class InventoryItemStuff : InventoryItem


{
    public void Awake()
    {
        type = ItemType.Stuff;
    }
    
}
