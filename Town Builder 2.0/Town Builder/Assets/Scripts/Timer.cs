using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float daysFloat;
    public int days;
    public int months;
    public int year;

    public TextMeshProUGUI dayDisplay;
    public TextMeshProUGUI monthDisplay;
    public TextMeshProUGUI yearDisplay;


    // Update is called once per frame
    void Update()
    {
        daysFloat += Time.deltaTime / 2;

        if(daysFloat>= 1)
        {
            daysFloat = 0;
            days++;
        }
        if(days>= 30)
        {
            days = 0;
            months++;
        }
        if (months >= 12)
        {
            months = 0;
            year++;
        }
        dayDisplay.text = days.ToString();
        monthDisplay.text = months.ToString();
        yearDisplay.text = year.ToString();
    }


}
