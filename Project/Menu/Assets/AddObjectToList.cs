using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddObjectToList : MonoBehaviour
{
    public GameObject game;
    public GameObject itemTemplate;
    public GameObject content;
    int index = 0;

    private GameObject copy = null;


    public void AddShop_Click()
    {
        game.GetComponent<GameDataScripty>().game.createShop(100);
        copy = Instantiate(itemTemplate) as GameObject; 
        copy.transform.parent = content.transform;
        copy.SetActive(true);
        copy.GetComponent<AddObjectToList>().index = index;
        copy.GetComponentInChildren<Text>().text = ("Shop " + (index) + "\n Income:\t\t\t Cost: ");

      
        index++;
    }
   public void shop_click()
   {
        Debug.Log("Index: " + index.ToString());

   }

    void Update()
    {
        if (copy != null)
        copy.GetComponentInChildren<Text>().text = ("Shop " + (index).ToString() + "\n  Income: " 
            + (int)game.GetComponent<GameDataScripty>().game.getIncome(game.GetComponent<GameDataScripty>().game.level) + "\t\t Cost: "
            + (int)game.GetComponent<GameDataScripty>().game.getCosts(game.GetComponent<GameDataScripty>().game.level));
    }
  
}
