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
            if (Convert.ToInt32(SecondNumber.text) != 0)
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
                Result.text = (Convert.ToInt32(SecondNumber.text)).ToString();
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
            decimal i = decimal.MaxValue;
            int j;
            float k;

            j = int.Parse(FirstNumber.text);
            Debug.Log("First number > " + j);

            j = int.Parse(FirstNumber.text);
            Debug.Log("Second number > " + j);

            k = Mathf.Pow(float.Parse(FirstNumber.text), float.Parse(SecondNumber.text));
            Debug.Log("Result in float > " + k);
            decimal l = Convert.ToDecimal(k);
            Debug.Log("Result in decimal > " + l);

            try
            {
                l = checked(i + l);
                Result.text = l.ToString();
            }
            catch (OverflowException ex)
            {
                Debug.Log(ex);
                Result.text = l.ToString();
            }

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