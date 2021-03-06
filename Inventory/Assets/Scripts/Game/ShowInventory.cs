using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowInventory : MonoBehaviour
{
    public InventoryObject inventory;

    public int xStart;
    public int yStart;
    public int xSpace;
    public int ySpace;
    public int numberOfColumn;

    [SerializeField] private GameObject[] Prefabs;
    private Dictionary<InventorySlot, GameObject> itemsDisplayed = new Dictionary<InventorySlot, GameObject>();

    
    void Start()
    {
        CreateDisplay();
    }
    void Update()
    {
        UpdateDisplay();
    }

    public void UpdateDisplay()
    {
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            
           //if (inventory.Container[i].amount <= 0) // fixa så bilden försvinner om jag har noll av nått och allt flyttas om man tar bort använder inte måste fixas
           //{
           //    Destroy(itemsDisplayed[inventory.Container[i]]);
           //    itemsDisplayed.Remove(inventory.Container[i]);
           //    inventory.Container.RemoveAt(i);
           //    continue;

           //}
            if (itemsDisplayed.ContainsKey(inventory.Container[i]))
            {
                itemsDisplayed[inventory.Container[i]].GetComponentInChildren<TextMeshProUGUI>().text =
                    inventory.Container[i].amount.ToString("n0");
            }
            else
            {
                     GameObject obj = Instantiate(Prefabs[(int)inventory.Container[i].item], Vector3.zero, Quaternion.identity, transform);
                     obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                     obj.GetComponentInChildren<TextMeshProUGUI>().text = inventory.Container[i].amount.ToString("n0");
                     itemsDisplayed.Add(inventory.Container[i], obj);
            }
        }
    }

    public void CreateDisplay()
    {
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            GameObject obj = Instantiate(Prefabs[(int)inventory.Container[i].item], Vector3.zero, Quaternion.identity, transform);
            obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
            obj.GetComponentInChildren<TextMeshProUGUI>().text = inventory.Container[i].amount.ToString("n0");
            
            itemsDisplayed.Add(inventory.Container[i], obj);
            
        }
    }

    public Vector3 GetPosition(int i)
    {
        return new Vector3(xStart+ (xSpace * (i % numberOfColumn)), yStart +(-ySpace * (i / numberOfColumn)), 0f);
    }
}
