using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public string name;
    public string sex;
    public int level;
    public int cost;
    public double initialIncome;

    public GameObject game;
    private GameClass player;

    void Start()
    {
        player = game.GetComponent<GameDataScripty>().game;
        //player.managers.Add(this);
    }
    
    
    public Manager(int setLevel, int setCost, string setName, string setSex, float setIncome)
    {
        level = setLevel;
        cost = setCost;
        name = setName;
        sex = setSex;
        initialIncome = setIncome;
    }
    public Manager()
    {
        level = 1;
        cost = 2;
        initialIncome = 5;
    }

    public void setLevel(int resetLevel)
    {
        level = resetLevel;
    }
    public void setCost(int resetCost)
    {
        cost = resetCost;
    }
    public int getLevel()
    {
        return level;
    }
    public float getCost()
    {
        return cost;
    }
    public string getName()
    {
        return name;
    }
    public string getSex()
    {
        return sex;
    }
}
