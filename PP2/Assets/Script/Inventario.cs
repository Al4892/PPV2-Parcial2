using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public int ActiveSlot = 0;
    public Transform slot;
    public Transform[] InventorySlots;
    // Start is called before the first frame update
    void Start()
    {
        InventorySlots = slot.GetComponentsInChildren<Transform>();
        InventorySlots[ActiveSlot].GetChild(0).gameObject.SetActive(true);
    } 

    // Update is called once per frame
    void Update()
    {
        InventorySlots[ActiveSlot].GetChild(0).gameObject.SetActive(true);
    }
}
