using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CaloriesCalculator : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_InputField firstName;
    public TMP_InputField lastName;
    public TMP_InputField addChicken;
    public TMP_InputField addrice;
    public TMP_InputField addBeans;
    public TMP_InputField addSteak;
    public TextMeshProUGUI mytext;
    const int chickencalories = 180;
    const int SteakCalories = 190;
    const int RiceCalories = 200;
    const int BeansCalories = 120;


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
        mytext.text = firstName.text +" " + lastName.text + totalFoodCalories.ToString();
    }



    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
