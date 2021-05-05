using UnityEngine;
using System;
using System.Collections.Generic;
public class GameClass: MonoBehaviour{
    public double money; 
    public double costs; 
    public double income;
    List<Shop> shops = new List<Shop>();

    public int level = 0;

    public List<Manager> managers = new List<Manager>();

    void Start()
    {
        money = 1000;
    }

    public GameClass() {
        money = 1000;
    }

    public GameClass(double setMoney, double setIncome, List<Shop> setArrayShop) {
        money = setMoney; 
        income = setIncome;
        shops = setArrayShop;
    } 

    public double getMoney() {
        return money;
    }
    //public void updateMoney()
    //{
    //    for (int i = 0; i < shops.Count; i++)
    //    {
    //        money += shops[i].profits;
    //    }
    //}

    public double getCosts(int level) {
        return 20 * level;
    }

    public double getIncome(int level) {
        return 100 * level;
    }

    public List<Shop> getArrayShop() {
        return shops;
    }

    public void setMoney(double setMoney) {
        money = setMoney;
    }

    public void setCosts(double setCosts) {
        costs = setCosts;
    }

    public void setIncome(double setIncome) {
        income = setIncome;
    }

    public void setArrayShop(List<Shop> setArrayShop) {
        shops = setArrayShop;
    }
    
    public void createShop(double shopCost)
    {   
        if (level < 1)
        {
            level++;
        }
        if (money >= shopCost)
        {
            money -= shopCost;
            Shop newShop = new Shop(this);
            shops.Add(newShop);
        } else
        {
            throw new System.Exception();
        }
    }

    public void hireManagers(int managerCost)
    {
        if (money >= managerCost)
        {
            money -= managerCost;
            Manager manager = new Manager();
            managers.Add(manager);
        }
        else
        {
            throw new System.Exception();
        }
    }

    public void UpgradeShop()
    {
        level++;
    }
}