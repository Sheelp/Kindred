using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NameTransfer : MonoBehaviour
{
    public string townName;
    public GameObject inputField;
    public GameObject textDisplay;
    public GameObject overlay;

    private void Start()
    {
        Time.timeScale = 0f;
    }

    public void StoreName()
    {
        townName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = townName;
        overlay.SetActive(false);
        Time.timeScale = 1f;
    }


    
}
