using System.Collections.Generic;
using UnityEngine;

public class StockShelf : MonoBehaviour
{
    private List<string> shelfItems = new List<string>();  // List to store items placed on the shelf

    // Method to add an item to the shelf
    public void AddItemToShelf(string item)
    {
        shelfItems.Add(item);
        Debug.Log("Item added to the shelf: " + item);
    }

    // Method to show all items on the shelf
    public void ShowShelfItems()
    {
        if (shelfItems.Count > 0)
        {
            Debug.Log("Items on the shelf: " + string.Join(", ", shelfItems));
        }
        else
        {
            Debug.Log("The shelf is empty.");
        }
    }
}
