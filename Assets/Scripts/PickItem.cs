using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public string itemName;
    public bool isInRange = false; // To check if player is close enough to the item
    public KeyCode pickupKey = KeyCode.E; // Key to press for picking up the item

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the player enters the item's trigger zone
        if (other.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("Player is in range to pick up: " + itemName);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Check if the player leaves the item's trigger zone
        if (other.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("Player left the range of: " + itemName);
        }
    }

    private void Update()
    {
        // If the player is in range and presses the pickup key, pick up the item
        if (isInRange && Input.GetKeyDown(pickupKey))
        {
            PickUpItem();
        }
    }

    // Handle the item pickup logic
    void PickUpItem()
    {
        Debug.Log("Picked up: " + itemName);

        // Disable the item's game object from picking it up
        gameObject.SetActive(false);

        // Adds the item to the player's inventory
        // Inventory.Add(itemName);
    }
}
