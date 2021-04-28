using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shop : MonoBehaviour
{
    /** @managers a list of managers/employees */
    private Manager[] managers;

    /** @costs costs per time increment*/
    private double costs;

    /** @income income per time increment*/
    private double income;

    /** @level Shop level*/
    private int level;

    /** @player the player, created when a shop is bought by the player, used to upadate the status*/
    public GameClass player;

    // Start is called before the first frame update
    void Start()
    {
        //set to be 6-10 seconds, should also be affected by the managers and area in future dev
        randomUpdateTime = Random.Range(6, 10);
    }

    /** @randomUpdateTime a random amount of time to simulate the time between consumptions*/
    private float randomUpdateTime;

    // Update is called once per frame
    void Update()
    {

        //countdown
        if (randomUpdateTime > 0)
        {
            randomUpdateTime -= Time.deltaTime;
        } else
        {
            UpdateMoney();
            //set to be 6-10 seconds, should also be affected by the managers and area in future dev
            randomUpdateTime = Random.Range(6, 10);
        }

    }

    // return the money to update. The moeny is based on the income & cost of shop itself and the manager's ability
    void UpdateMoney()
    {
        float managerIncome = 0.0;
        float managerCost = 0.0;
        for (int i = 0; i < managers.Length; i ++)
        {
            managerIncome += managers[i].getLevel() * managers[i].initialIncome * 100;
            managerCost += managers[i].getLevel() * managers[i].cost * 50;
        } 
        player.money += income + managerIncome - costs - managerCost;
    }
    //create a default shop of level 1
    public Shop()
    {
        level = 1;
        Gameclass player = new Gameclass()
    }
    //increase the shop level
    void updateShop(int updateCost)
    {
        if (player.money >= updateCost)
        {
            level++;
            income += level * 20;
            costs += level * 15;
            player.money -= updateCost;
        } else
        {
            throw new System.Exception;
        }
    }
   

    //Create a new manager and put it into the Manager list. 
    //The managerCost parameter will based on the level of manager the user decide to hire
    void hireManagers(int managerCost, int shopLevel)
    {
        if (player.money >= managerCost && level <= shopLevel)
        {
            player.money -= managerCost;
            Manager manager = new Manager();
            managers.Add(manager);
        } else
        {
            throw new System.Exception;
        }
    }


    void SetManagers(Manager[] m)
    {
        managers = m;
    }

    Manager[] GetManagers()
    {
        return managers;
    }

    void SetCosts(double c)
    {
        costs = c;
    }

    double GetCosts()
    {
        return costs;
    }

    void SetIncome(double i)
    {
        income = i;
    }

    double GetIncome()
    {
        return income;
    }

    void SetLevel(int l)
    {
        level = l;
    }

    int GetLevel()
    {
        return level;
    }
}
