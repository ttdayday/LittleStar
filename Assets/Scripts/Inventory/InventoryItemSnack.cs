using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Stuff Item", menuName = "Inventory/Item/Snack")]
public class InventoryItemSnack : InventoryItem
{
    public int increaseHappinessValue;
    public void Awake()
    {
        type = ItemType.Snack;
    }

}