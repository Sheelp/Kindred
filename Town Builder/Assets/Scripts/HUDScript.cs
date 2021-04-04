using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour
{

    public static int Currency;
    Text currencyText;
    // Start is called before the first frame update
    void Start()
    {
        
        currencyText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Currency = GameObject.Find("GameHandler").GetComponent<GameHandler>().Currency;
        currencyText.text = "Currency " + Currency.ToString();
    }
}
