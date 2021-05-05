using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyText : MonoBehaviour
{
    public GameObject game;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<TMP_Text>().text = "Player Money: " + (int)game.GetComponent<GameDataScripty>().game.getMoney();
    }
}
