using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHandler : MonoBehaviour
{

    bool toggle = false;
    GameObject[] handler;


    //toggles SetActive of Game Objects
    public void Handler()
    {
        if (toggle == false)
        {
            handler = FindActiveGameObjectsWithLayer(LayerMask.NameToLayer("UI"));
            {
                for (int i = 0; i < handler.Length; i++)
                {
                    handler[i].SetActive(false);
                }
            }
            toggle = true;
        }
        else
        {
            for (int i = 0; i < handler.Length; i++)
            {
                handler[i].SetActive(true);
            }
            toggle = false;
        }
    }

    //Find All Active Game Objects associated with the layer
    GameObject[] FindActiveGameObjectsWithLayer(int layer)
    {
        GameObject[] goArray = FindObjectsOfType(typeof(GameObject)) as GameObject[];
        List<GameObject> goList = new List<GameObject>();
        for (int i = 0; i < goArray.Length; i++)
        {
            if (goArray[i].layer == layer)
            {
                goList.Add(goArray[i]);
            }
        }
        if (goList.Count == 0)
        {
            return null;
        }
        return goList.ToArray();
    }
}