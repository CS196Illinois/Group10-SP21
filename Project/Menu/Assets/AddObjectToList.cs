using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddObjectToList : MonoBehaviour
{
    public GameObject itemTemplate;
    public GameObject content;
    int index = 0;

    public void AddShop_Click()
    {
        var copy = Instantiate(itemTemplate);
        copy.transform.parent = content.transform;
        copy.GetComponentInChildren<Text>().text = ("Shop " + (index + 1).ToString() + " (name)\n Shop Income:\t\t\t Shop Cost: ");

      
        index++;
    }
  
}
