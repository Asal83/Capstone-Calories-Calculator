using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KhoroshtsabziCalories : MonoBehaviour
{
    public TMP_InputField addpotato;
    public TMP_InputField addredbean;
    public TMP_InputField addoil;
    public TMP_InputField addmeat;
    public TMP_Dropdown meatDd;
    public TextMeshProUGUI mytext;
    const int beans = 333;
    const int Potato = 77;
    const int oliveoil = 884;
    const int Meat = 143;
    const int lamb = 294;
    const int beaf = 250; 

    public void khoroshtSabziCalories()
    {
        int khoroshtTotalCalories = 0;
        int AddPotato = int.Parse(addpotato.text);
        int Addreadbean = int.Parse(addredbean.text);
        int Addoil = int.Parse(addoil.text);
        int Addmeat = int.Parse(addmeat.text);

        

        khoroshtTotalCalories += AddPotato * Potato;
        khoroshtTotalCalories += Addreadbean * beans;
        khoroshtTotalCalories += Addoil * oliveoil;
        if (meatDd.value == 0)
        {
            khoroshtTotalCalories += Meat * Addmeat;
        }
        else if (meatDd.value == 1)
        {
            khoroshtTotalCalories += lamb * Addmeat;
        }
        else if (meatDd.value == 2)
        {
            khoroshtTotalCalories += beaf * Addmeat;
        }

        mytext.text = khoroshtTotalCalories.ToString();


    }



}
