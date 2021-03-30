public class GameClass{
    float money; 
    float costs; 
    float income; 
    Shop[] shops;

    public GameClass() {}

    public GameClass(float setMoney, float setCosts, float setIncome, Shop[] setArrayShop) {
        money = setMoney; 
        costs = setCosts;
        income = setIncome;
        shops = setArrayShop;
    } 

    public float getMoney() {
        return money;
    }

    public float getCosts() {
        return costs;
    }

    public float getIncome() {
        return income;
    }

    public Shop[] getArrayShop() {
        return shops;
    }

    public float setMoney(float setMoney) {
        money = setMoney;
    }

    public float setCosts(float setCosts) {
        costs = setCosts;
    }

    public float setIncome(float setIncome) {
        income = setIncome;
    }

    public float setArrayShop(Shop[] setArrayShop) {
        shops = setArrayShop;
    }
 
}