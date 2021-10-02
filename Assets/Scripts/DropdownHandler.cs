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

        chef.SetActive(true);
        itemName = gameObject.GetComponent<Dropdown>().options[val].text;
        item = parent.transform.Find(itemName);
        orderReadyText.text = "Your " + itemName + "\nis ready!";
        item.gameObject.SetActive(true);
    }
}
