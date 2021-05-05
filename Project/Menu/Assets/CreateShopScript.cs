using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateShopScript : MonoBehaviour
{
    //public GameClass game;
    public GameObject Panel;

    public void OpenPanel()
    {
        if(Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }

}
