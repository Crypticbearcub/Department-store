using UnityEngine;

public class ItemSeller : MonoBehaviour
{

    public float playerMoney;
    public float itemSellPrice;
    public string requiredItem;

    // Item that the player attempts to sell
    public GameObject itemToSell;

    // Checks if player is in the selling range
    private bool isInSellingRange = false;

    // R key is for selling an item
    public KeyCode sellKey = KeyCode.R;

    void Update()
    {
        // If player is in the selling range and presses down the key, it attempts to sell the item
        if (isInSellingRange && Input.GetKeyDown(sellKey))
        {
            AttemptToSellItem();
        }
    }

    void AttemptToSellItem()
    {
        // Checks if the item exists and is customer's required item
        if (itemToSell != null && itemToSell.name == requiredItem)
        {
            // Sell item and add received money to the player
            SellItem();
        }
        else
        {
            Debug.Log("This is not what I wanted.");
        }
    }

    void SellItem()
    {
        // Add received money from the sold item to the player
        playerMoney += itemSellPrice;

        // Inventory.Remove(itemToSell);
        // Delete item from the game world
        Destroy(itemToSell);
        Debug.Log("Item sold! Received money: " + itemSellPrice);
        Debug.Log("Money now: " + playerMoney);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // If player steps to the selling range (Cash register)
        if (other.CompareTag("Player"))
        {
            isInSellingRange = true;
            Debug.Log("You are in the selling range. Press 'R' to sell the item.");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // If player leaves the selling range
        if (other.CompareTag("Player"))
        {
            isInSellingRange = false;
            Debug.Log("You left from the selling range.");
        }
    }
}