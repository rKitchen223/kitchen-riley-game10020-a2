using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public TextMeshProUGUI pumpkinsText;
    public TextMeshProUGUI lanternsText;
    public TextMeshProUGUI coinsText;

    public void UpdateInventoryUI()
    {
        int pumpkinsInventory = inventoryManager.inventory[InventoryItem.Pumpkin];
        pumpkinsText.text = $"Pumpkins: {pumpkinsInventory}";

        int lanternsInventory = inventoryManager.inventory[InventoryItem.Lantern];
        lanternsText.text = $"Lanterns: {lanternsInventory}";

        int coinsInventory = inventoryManager.inventory[InventoryItem.Coins];
        coinsText.text = $"Coins {coinsInventory}";
    }
}
