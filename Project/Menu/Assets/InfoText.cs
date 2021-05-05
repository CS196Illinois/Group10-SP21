using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoText : MonoBehaviour
{
    public GameObject game;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Text>().text = "Shop Level: " + game.GetComponent<GameDataScripty>().game.level + "\nManagers: " 
            + game.GetComponent<GameDataScripty>().game.managers.Count;
    }
}
