using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryDisplay : MonoBehaviour
{
    public void ShowOnly(int itemType)

    {
        for (int i =0; i < transform.childCount; i++)
        {
            InventoryItemButton thisItem = transform.GetChild(i).GetComponent<InventoryItemButton>();
            thisItem.gameObject.SetActive(thisItem.index == itemType);
        }
    }

    public void ShowAll()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            InventoryItemButton thisItem = transform.GetChild(i).GetComponent<InventoryItemButton>();
            thisItem.gameObject.SetActive(true);
        }
    }
}
