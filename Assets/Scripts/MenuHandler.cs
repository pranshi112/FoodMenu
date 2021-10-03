using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHandler : MonoBehaviour
{

    bool toggle = false;

    public GameObject[] handler;
    public GameObject[] handler2;

    //toggles SetActive of Game Objects
    public void Handler()
    {
        if (toggle == false)
        {
            List<GameObject> goToList = new List<GameObject>();
            for (int i = 0; i < handler.Length; i++) { 
                    if (handler[i].activeInHierarchy)
                    {
                        handler[i].SetActive(false);
                        goToList.Add(handler[i]);
                    }
            }
            handler2 = goToList.ToArray();
            toggle = true;
        }
        else
        {
            for (int i = 0; i < handler2.Length; i++)
            {
                handler2[i].SetActive(true);
            }
            toggle = false;
        }
    }
}
