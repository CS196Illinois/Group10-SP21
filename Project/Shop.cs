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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Shop()
    {
        level = 1;
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
