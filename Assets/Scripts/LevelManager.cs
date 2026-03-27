using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public UIManager uiManager;
    public InventoryManager inventoryManager;

    public Barrier  barriers1;
    public Toggle toggle1;
    public Door door;
    public GameObject inventoryItems;


    // the level manager is responsible for connecting the core game system events
    // notice that these events have arguments - it's not possible to pass arguments to
    // events in Unity when using the Editor (what we did in Module 1)
    // arguments make the events more flexible

    private void Start()
    {
        inventoryManager.OnInventoryChanged.AddListener(uiManager.UpdateInventoryUI);
        toggle1.OnToggle.AddListener(barriers1.Move);

        foreach (Transform child in inventoryItems.transform)
        {
            Inventory inventory = child.GetComponent<Inventory>();
            inventory.OnItemCollected.AddListener(inventoryManager.PickUpInventory);
        }

        foreach (Transform child in barriers1.transform)
        {
            Barrier barrier = child.GetComponent<Barrier>();
            toggle1.OnToggle.AddListener(barrier.Move);
        }
        lockDoor();
    }

    void lockDoor()
    {
       
        {
            door.SetLock(false);
        }
    }
}
