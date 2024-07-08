using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{ 
    Stuff,
    Snack

}

public class InventoryItem : ScriptableObject
{
    public ItemType type;
    public string itemName;
    public GameObject prefab; // Prefab for the item in the manipulation view
    [TextArea(5, 20)]
    public string description;
}