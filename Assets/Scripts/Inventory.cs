using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private string currentItem = null;  // The item the player is holding, null means empty

    // Method to pick up an item
    public void PickUpItem(string item)
    {
        if (currentItem == null)
        {
            currentItem = item;
            Debug.Log("Picked up: " + item);
        }
        else
        {
            Debug.Log("Inventory slot is full! Cannot pick up another item.");
        }
    }

    // Method to sell the item in the inventory
    public void SellItem()
    {
        if (currentItem != null)
        {
            Debug.Log("Sold: " + currentItem);
            currentItem = null;  // Clear the inventory slot
        }
        else
        {
            Debug.Log("No item to sell!");
        }
    }

    // Method to place the item on a shelf
    public void PlaceOnShelf(StockShelf shelf)
    {
        if (currentItem != null)
        {
            shelf.AddItemToShelf(currentItem);
            Debug.Log("Placed " + currentItem + " on the shelf.");
            currentItem = null;  // Clear the inventory slot after placing item on the shelf
        }
        else
        {
            Debug.Log("No item to place on the shelf!");
        }
    }

    // Check if inventory slot is free
    public bool IsSlotFree()
    {
        return currentItem == null;
    }
}
