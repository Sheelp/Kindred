using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    private int timer = 0;

    public int CurrencyInterval = 3;

    public float startBuildTime;
    public float buildTime;

    public int workers = 1;


    // Start is called before the first frame update
    void Start()
    {
        buildTime = startBuildTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        buildTime -= Time.deltaTime * workers;
        if (buildTime <= 0)
        {
            buildTime = 0;
            if (timer == CurrencyInterval * 60)
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
}
