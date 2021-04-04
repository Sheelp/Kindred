using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    private int timer = 0;

    public int CurrencyInterval = 3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(timer == CurrencyInterval*60)
		{
            timer = 0;
            GameObject.Find("GameHandler").GetComponent<GameHandler>().Currency += 1;
        }
        else
		{
            timer++;
        }
        
    }
}
