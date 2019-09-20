using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CaloriesCalculator : MonoBehaviour
{
    // Start is called before the first frame update
    
   
    public TMP_InputField addChicken;
    public TMP_InputField addrice;
    public TMP_InputField Yogurt;
    public TMP_InputField addBeans;
    public TMP_InputField addSteak;
    public TMP_InputField addEggplanet;
    public TMP_InputField addKashk;
    public TMP_InputField addOnion;
    public TMP_InputField oil;
    public TMP_Dropdown RiceDd;
    public TMP_Dropdown ChickenDd;
    public TMP_Dropdown YogurtDd;
    public TMP_Dropdown EggplanetDd;
    public TMP_Dropdown OilDd;
    public TextMeshProUGUI mytext;
    const int chickencalories = 180;
    const int SteakCalories = 190;
    const int RiceCalories = 200;
    const int BeansCalories = 120;
    const int whiteRice = 130;
    const int BrownRice = 111;
    const int chickenBreast = 165;
    const int ChickenThigh = 209;
    const int GreekYogurt = 59;
    const int Breyers = 96;
    const int BoiledEggplanet = 35;
    const int FriedEggplanet = 106;
    const int OliveOil = 884;
    const int CoconutOil = 862;
    const int FriedOnion = 258;
    const int Kashk = 50;
    




    public void TotalMealCalories()
    {
        int totalFoodCalories = 0;
        int AddChicken = int.Parse(addChicken.text);
        int AddRice = int.Parse(addrice.text);
        int AddBeans = int.Parse(addBeans.text);
        int AddSteak = int.Parse(addSteak.text);
        totalFoodCalories += AddChicken * chickencalories;
        totalFoodCalories += (AddRice * chickencalories);
        totalFoodCalories += (AddBeans * chickencalories);
        totalFoodCalories += (AddSteak * chickencalories);
        mytext.text = totalFoodCalories.ToString();
    }
    public void TahchinCalories()
    {
        int totaltahchinCalories = 0;
        int AddRice = int.Parse(addrice.text);
        int AddChicken = int.Parse(addChicken.text);
        int AddYogurt = int.Parse(Yogurt.text);
        if (RiceDd.value == 0)
        {
             totaltahchinCalories += AddRice * whiteRice;
        }
        else if (RiceDd.value == 1)
        {
            totaltahchinCalories += AddRice * BrownRice;
        }
        if (ChickenDd.value == 0)
        {
            totaltahchinCalories += AddChicken * chickenBreast;
        }
        else if (ChickenDd.value == 1)
        {
            totaltahchinCalories += AddChicken * ChickenThigh;
        }
        if (YogurtDd.value == 0)
        {
            totaltahchinCalories += AddYogurt * GreekYogurt;
        }
        else if (YogurtDd.value == 1)
        {
            totaltahchinCalories += AddYogurt * Breyers;
        }
        mytext.text = totaltahchinCalories.ToString();

        
    }

    public void KashkBadenjoonCalories()
    {
        int Addeggplanet = int.Parse(addEggplanet.text);
        int Addkashk = int.Parse(addKashk.text);
        int Addonion = int.Parse(addOnion.text);
        int AddOil = int.Parse(oil.text);
        int totalkashkBCalories = 0;
        if (EggplanetDd.value == 0)
        {
            totalkashkBCalories += Addeggplanet * FriedEggplanet;
        }
        else if (EggplanetDd.value == 1)
        {
            totalkashkBCalories += Addeggplanet * BoiledEggplanet;
        }
        if (OilDd.value == 0)
        {
            totalkashkBCalories += AddOil * OliveOil;
        }
        else if (OilDd.value == 1)
        {
            totalkashkBCalories += AddOil * CoconutOil;
        }
        totalkashkBCalories += Addkashk * Kashk;
        totalkashkBCalories += Addonion * FriedOnion;
        mytext.text = totalkashkBCalories.ToString();
    }
    



    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
