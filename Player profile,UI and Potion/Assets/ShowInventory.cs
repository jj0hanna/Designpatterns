using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowInventory : MonoBehaviour
{
    public InventoryObject inventory;

    public int xSpace;
    public int ySpace;
    public int numberOfColumn;

    private Dictionary<InventorySlot, GameObject> itemsDisplayed = new Dictionary<InventorySlot, GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        CreateDisplay();
    }

    // Update is called once per frame
    void Update()
    {
       // UpdateDisplay();
    }

    public void CreateDisplay()
    {
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            var obj = Instantiate(inventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform);
            obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
            obj.GetComponentInChildren<TextMeshProUGUI>.text = inventory.Container[i].amount.ToString("n0");
            
        }
    }

    public Vector3 GetPosition(int i)
    {
        return new Vector3(xSpace * (i % numberOfColumn), (-ySpace * (i / numberOfColumn)), 0f);
    }
}
