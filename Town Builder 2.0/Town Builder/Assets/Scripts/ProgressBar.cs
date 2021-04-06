using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{

    public Slider slider;

    public void SetBuildTime(float buildTime)
    {
        slider.value = buildTime;
    }
    public void setMaxBuildTime(int buildTime)
    {
        slider.maxValue = buildTime;
        slider.value = buildTime;
    }
}
