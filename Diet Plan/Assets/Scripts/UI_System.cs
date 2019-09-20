using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_System : MonoBehaviour
{
    UI_Pages PreviousPage;
    UI_Pages CurrentPage;
    void Start()
    {
        UI_Pages[] pages = GetComponentsInChildren<UI_Pages>(true);//when we set it True ,it gives us all the pages Active or disActive.
        pages[0].gameObject.SetActive(true);//when I open the App on mobile I want the first page to be displayed.my code come I want all the pages be
        //disactive and active the current page.
        for (int i = 1; i < pages.Length; i++)
        {
            pages[i].gameObject.SetActive(false);
        }
        CurrentPage = pages[0];
    }
    public void SwitchPage(UI_Pages nextPage)
    {//Disable the current page then enable the next page which is Page,we need a method to switch pages.it recives the page we are going to switch to 
     //ex)we are in the second page and want to switch to first page,we Just need to know to which page are going to switch.
     //I am going to diable the current page make it invisible then enable the next page make it appear which is .
     //we first need to know what is the current page,for now I define a variable call current page.
     //what do we need,we switching page staring from stating page to
     //
     //another page,say wind page.so we need a method to do that for us.It receives the page we are going to switch to .
     //
        PreviousPage = CurrentPage;//current page is the one when you run the program the first element.
        CurrentPage.gameObject.SetActive(false);
        nextPage.gameObject.SetActive(true);
        CurrentPage = nextPage;
    }
    public void GoToPreviousPage()
    {
        SwitchPage(PreviousPage);//for Back Button.
    }

}
