using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataScripty : MonoBehaviour
{
    public GameClass game;
    public double playerMoney;
    // Start is called before the first frame update
    void Start()
    {
        game = new GameClass();
        //playerMoney = game.getMoney();
    }

    public void UpgradeLevel()
    {
        
        if (game.money >= 50)
        {
            game.level++;
            game.money -= game.level * 50;
        }
    }

}
