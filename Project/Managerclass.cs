using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private string name;
    private sex;
    private string level;
    private int cost;
    private float initialIncome;
    

    public Manager(string setLevel, int setCost, string setName, string setSex, float setIncome)
    {
        level = setLevel;
        cost = setCost;
        name = setName;
        sex = setSex;
        initialIncome = setIncome;
    }
    public Manager()
    {
        level = "rookie";
        cost = 0;
    }

    public void setLevel(string resetLevel)
    {
        level = resetLevel;
    }
    public void setCost(int resetCost)
    {
        cost = resetCost;
    }
    public string getLevel()
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
  


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
