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

        Result.text = (Convert.ToInt32(FirstNumber.text) + Convert.ToInt32(SecondNumber.text)).ToString();
    }

    public void OnClickMinus()
    {

        Result.text = (Convert.ToInt32(FirstNumber.text) - Convert.ToInt32(SecondNumber.text)).ToString();
    }

    public void OnClickMultiply()
    {

        Result.text = (Convert.ToInt32(FirstNumber.text) * Convert.ToInt32(SecondNumber.text)).ToString();
    }

    public void OnClickDivide()
    {

        if (Convert.ToInt32(SecondNumber.text) != 0) {

            Result.text = (Convert.ToInt32(FirstNumber.text) / Convert.ToInt32(SecondNumber.text)).ToString();
            }
        else Result.text = "DIVISION BY ZERO!";
    }

};