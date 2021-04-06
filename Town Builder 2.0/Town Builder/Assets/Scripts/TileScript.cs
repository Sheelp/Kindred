using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    private int timer = 0;

    public int CurrencyInterval = 3;

    public int WoodIncrease;

    public int MetalIncrease;

    public int StoneIncrease;


    public float buildTime = 0;
    public int maxBuildTime;
    public int workers;

    public ProgressBar progressBar;
    public GameObject bar;


    // Start is called before the first frame update
    void Start()
    {
        buildTime = 0;

        progressBar.setMaxBuildTime(maxBuildTime);
    }

    // Update is called once per frame
    private void Update()
    {
        if (buildTime < maxBuildTime)
        {
            buildTime += Time.deltaTime * workers;
            progressBar.SetBuildTime(buildTime);
        }
    }
    void FixedUpdate()
    {
       
        if (buildTime>=maxBuildTime) 
        {
            buildTime = maxBuildTime;
            bar.SetActive(false);
            if (timer == CurrencyInterval * 60)
            {
                timer = 0;
                GameObject.Find("GameHandler").GetComponent<GameHandler>().Wood += WoodIncrease;
                GameObject.Find("GameHandler").GetComponent<GameHandler>().Metal += MetalIncrease;
                GameObject.Find("GameHandler").GetComponent<GameHandler>().Stone += StoneIncrease;
            }
            else
            {
                timer++;
            }
        }
    }
}
