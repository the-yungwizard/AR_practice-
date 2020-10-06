using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operands : MonoBehaviour
{
    public string myName = "Billy";
    public int myAgeInYears = 29;
    public int myAgeInMonths = 0;
    public int myAgeInWeeks = 0;
    public int myAgeInDays = 0;
    public int myBirthdayDay = 21;
    public int myBirthdayMonth = 07; 
    public int myBirthdayYear = 1990;

    // Start is called before the first frame update
    void Start()
    {


        string myDebugMessage = " My Name is: " + myName + " my birthday is: " + myBirthdayDay + "/" + myBirthdayMonth;
        myDebugMessage = myDebugMessage + " my age in years is: " + myAgeInYears;

        myAgeInMonths = myAgeInYears = 12;
        myAgeInWeeks = myAgeInMonths = 4;
        myAgeInDays = myAgeInWeeks = 7;

        myDebugMessage += " My age in Months: " + myAgeInMonths;
        myDebugMessage += " My Age In Weeks is: " + myAgeInWeeks;
        myDebugMessage += " My age in days is: " + myAgeInDays;

        Debug.Log(myDebugMessage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
