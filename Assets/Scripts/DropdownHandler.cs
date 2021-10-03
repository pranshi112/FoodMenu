using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownHandler : MonoBehaviour
{
    private string itemName;
    public GameObject parent;
    private Transform item;
    public GameObject chef;
    public Text orderReadyText;


    private void Start()
    {
        parent = GameObject.Find("Food Items");
    }

    public void HandleInput(int val)
    {
        var allFoodItems = GameObject.FindGameObjectsWithTag("Food Item");
        foreach (var food in allFoodItems)
            food.SetActive(false);

        itemName = gameObject.GetComponent<Dropdown>().options[val].text;
        item = parent.transform.Find(itemName);

        chef.SetActive(item != null);

        var displayText = "";
        if (val > 0)
        {
            displayText = item == null ? "Item unavailable! Order something else." : $"Your {itemName} is ready!";
        }
        orderReadyText.text = displayText;
        item?.gameObject.SetActive(true);
    }
}
