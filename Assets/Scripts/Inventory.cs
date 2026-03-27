using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Inventory : MonoBehaviour, IHittable
{
    public UnityEvent OnCoinCollected;
    [HideInInspector]
    public UnityEvent<InventoryItem> OnItemCollected;

    public InventoryItem item;

    public void Awake()
    {
        if (OnItemCollected == null) OnItemCollected = new UnityEvent<InventoryItem>();
    }

    public void Hit(GameObject otherObjectGameObject)
    {
        Destroy(gameObject);
        OnCoinCollected.Invoke();
    }
}
