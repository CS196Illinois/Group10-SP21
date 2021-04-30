﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerAddObjectToList : MonoBehaviour
{
    public GameObject itemTemplate;
    public GameObject content;
    int index = 0;

    public void AddManager_Click()
    {
        var copy = Instantiate(itemTemplate);
        copy.transform.parent = content.transform;
        copy.GetComponentInChildren<Text>().text = ("Manager " + (index + 1).ToString() + "         Level:");

        index++;
    }
}
