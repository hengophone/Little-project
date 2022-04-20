using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Calculator : MonoBehaviour
{
    public Text Result;
    public InputField FirstNumber;
    public InputField SecondNumber;

    public void OnClickPlus()
    {

        Result.text = (Convert.ToDecimal(FirstNumber.text) + Convert.ToDecimal(SecondNumber.text)).ToString();
    }

    public void OnClickMinus()
    {

        Result.text = (Convert.ToDecimal(FirstNumber.text) - Convert.ToDecimal(SecondNumber.text)).ToString();
    }

    public void OnClickMultiply()
    {

        Result.text = (Convert.ToDecimal(FirstNumber.text) * Convert.ToDecimal(SecondNumber.text)).ToString();
    }

    public void OnClickDivide()
    {

        if (Convert.ToInt32(SecondNumber.text) != 0) 
        {
            Result.text = Decimal.Round((Convert.ToDecimal(FirstNumber.text) / Convert.ToDecimal(SecondNumber.text)),10).ToString();
        }
        else Result.text = "DIVISION BY ZERO!";
    }

    public void OnClickMin()
    {

        if (Convert.ToDecimal(FirstNumber.text) == Convert.ToDecimal(SecondNumber.text))
        {
            Result.text = "EQUAL NUMBERS";
        }
        else if (Convert.ToDecimal(FirstNumber.text) > Convert.ToDecimal(SecondNumber.text))
        {
            Result.text = (Convert.ToInt32(SecondNumber.text)).ToString();
        }
        else if (Convert.ToDecimal(FirstNumber.text) < Convert.ToDecimal(SecondNumber.text))
        {
            Result.text = (Convert.ToDecimal(FirstNumber.text)).ToString();
        }

    }

    public void OnClickMax()
    {

        if (Convert.ToDecimal(FirstNumber.text) == Convert.ToDecimal(SecondNumber.text))
        {
            Result.text = "EQUAL NUMBERS";
        }
        else if (Convert.ToDecimal(FirstNumber.text) < Convert.ToDecimal(SecondNumber.text))
        {
            Result.text = (Convert.ToDecimal(SecondNumber.text)).ToString();
        }
        else if (Convert.ToDecimal(FirstNumber.text) > Convert.ToDecimal(SecondNumber.text))
        {
            Result.text = (Convert.ToDecimal(FirstNumber.text)).ToString();
        }

    }
};