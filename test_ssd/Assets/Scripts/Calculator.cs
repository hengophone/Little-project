using UnityEngine;
using UnityEngine.UI;
using System;
using Math = System.Math;

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
            Result.text = "NO NUMBERS";
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
            Result.text = "NO NUMBERS";
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
            Result.text = "NO NUMBERS";
        }
    }

    public void OnClickDivide()
    {
        if (FirstNumber.text.ToString() != "" & SecondNumber.text.ToString() != "")
        {
            if (Convert.ToDecimal(SecondNumber.text) != 0)
            {
                Result.text = Decimal.Round((Convert.ToDecimal(FirstNumber.text) / Convert.ToDecimal(SecondNumber.text)), 10).ToString();
            }
            else Result.text = "DIVISION BY ZERO!";
        }
        else
        {
            Result.text = "NO NUMBERS";
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
                Result.text = (Convert.ToDecimal(SecondNumber.text)).ToString();
            }
            else if (Convert.ToDecimal(FirstNumber.text) < Convert.ToDecimal(SecondNumber.text))
            {
                Result.text = (Convert.ToDecimal(FirstNumber.text)).ToString();
            }
        }
        else
        {
            Result.text = "NO NUMBERS";
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
            Result.text = "NO NUMBERS";
        }
    }

    public void OnClickPower()
    {

        if (FirstNumber.text.ToString() != "" & SecondNumber.text.ToString() != "")
        {
            Debug.Log("Numbers Unequal > success");

            Double Base = Double.Parse(FirstNumber.text);
            Debug.Log("First number > " + Base);

            Double power = Double.Parse(SecondNumber.text);
            Debug.Log("Second number > " + power);

               //if (Math.Log(Double.MaxValue, Base) > power)
               // {
                    Result.text = Math.Pow(Base, power).ToString();
                    return;
               // }
               // else
               //{
               //    Result.text = Math.Pow(Base, power).ToString();
               // }
        }
        
        else
        {
            Result.text = "NO NUMBERS";
        }
    }

    public void OnClickQuit()
    {
        Application.Quit();
    }
};