using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeText : MonoBehaviour
{
    public GameObject game;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Text>().text = "Upgrade Shop to Level:\n\nNew Cost:	" 
            + (int)game.GetComponent<GameDataScripty>().game.getIncome(game.GetComponent<GameDataScripty>().game.level + 1)
            + "  New Income: " + (int)game.GetComponent<GameDataScripty>().game.getCosts(game.GetComponent<GameDataScripty>().game.level + 1);
    }
}
