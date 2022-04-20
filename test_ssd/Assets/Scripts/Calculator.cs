using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Globalization;

public class Calculator : MonoBehaviour
{
    public Text Result;
    public InputField FirstNumber;
    public InputField SecondNumber;

    
    public void OnClickPlus()
    {
        if (FirstNumber.text.ToString() != "" & SecondNumber.text.ToString() != "")
        {
            Result.text = (Convert.ToDecimal(FirstNumber.text) + Convert.ToDecimal(SecondNumber.text)).ToString();
        }
        else
        {
            Result.text = "NUMBERS MISSING";
        }
    }

    public void OnClickMinus()
    {
        if (FirstNumber.text.ToString() != "" & SecondNumber.text.ToString() != "")
        {
            Result.text = (Convert.ToDecimal(FirstNumber.text) - Convert.ToDecimal(SecondNumber.text)).ToString();
        }
        else
        {
            Result.text = "NUMBERS MISSING";
        }
    }

    public void OnClickMultiply()
    {
        if (FirstNumber.text.ToString() != "" & SecondNumber.text.ToString() != "")
        {
            Result.text = (Convert.ToDecimal(FirstNumber.text) * Convert.ToDecimal(SecondNumber.text)).ToString();
        }
        else
        {
            Result.text = "NUMBERS MISSING";
        }
    }

    public void OnClickDivide()
    {
        if (FirstNumber.text.ToString() != "" & SecondNumber.text.ToString() != "")
        {
            if (Convert.ToInt32(SecondNumber.text) != 0)
            {
                Result.text = Decimal.Round((Convert.ToDecimal(FirstNumber.text) / Convert.ToDecimal(SecondNumber.text)), 10).ToString();
            }
            else Result.text = "DIVISION BY ZERO!";
        }
        else
        {
            Result.text = "NUMBERS MISSING";
        }
    }

    public void OnClickMin()
    {
        if (FirstNumber.text.ToString() != "" & SecondNumber.text.ToString() != "")
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
        else
        {
            Result.text = "NUMBERS MISSING";
        }

    }

    public void OnClickMax()
    {
        if (FirstNumber.text.ToString() != "" & SecondNumber.text.ToString() != "")
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
        else
        {
            Result.text = "NUMBERS MISSING";
        }
    }

    public void OnClickPower()
    {
        if (FirstNumber.text.ToString() != "" & SecondNumber.text.ToString() != "")
        {
            // Result.text = Convert.ToDecimal(Math.Pow(FirstNumber, SecondNumber)).ToString();
            Result.text = System.Math.Pow(Convert.ToDouble(FirstNumber.text), Convert.ToDouble(SecondNumber.text)).ToString();
        }
        else 
        { 
            Result.text = "NUMBERS MISSING"; 
        }
    }

    public void OnClickQuit()
    {
        Application.Quit();
    }
};