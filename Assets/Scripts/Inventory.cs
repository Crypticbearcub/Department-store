/* using UnityEngine;
using static UnityEditor.Progress;

public class Inventory : MonoBehaviour
{
    // Fixed size inventory for 3 items
    private Inventoryslots[] items = new Inventoryslots[3];

    // Add an item to the inventory
    public bool Add(Inventoryslots newItem)
    {
        // Check if there's an empty slot in the inventory
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == null) // Empty slot found
            {
                items[i] = newItem;
                Debug.Log("Added " + newItem.itemName + " to inventory.");
                return true;
            }
        }

        Debug.Log("Inventory is full. Couldn't add " + newItem.itemName);
        return false;
    }

    // Remove an item from the inventory
    public bool Remove(Item itemToRemove)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == itemToRemove)
            {
                items[i] = null; // Remove the item
                Debug.Log("Removed " + itemToRemove.itemName + " from inventory.");
                return true;
            }
        }

        Debug.Log("Item not found in inventory.");
        return false;
    }

    // Check if an item exists in the inventory
    public bool HasItem(Item item)
    {
        foreach (Item invItem in items)
        {
            if (invItem == item)
            {
                Debug.Log("Inventory contains: " + item.itemName);
                return true;
            }
        }
        Debug.Log(item.itemName + " not found in inventory.");
        return false;
    }

    // Print all items in the inventory
    public void PrintInventory()
    {
        Debug.Log("Inventory:");
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] != null)
            {
                Debug.Log((i + 1) + ": " + items[i].itemName);
            }
            else
            {
                Debug.Log((i + 1) + ": Empty");
            }
        }
    }
} */
