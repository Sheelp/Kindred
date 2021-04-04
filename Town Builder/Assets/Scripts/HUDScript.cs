using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class HUDScript : MonoBehaviour
{

    public static int Currency;
    public static int Wood;
    public static int Stone;
    public static int Population;
    public static int Metal;

    Text currencyText;

    public TextMeshProUGUI woodText;
    public TextMeshProUGUI popText;
    public TextMeshProUGUI stoneText;
    public TextMeshProUGUI metalText;

    public GameObject buildmenu;

    public GameObject gameHandler;

    private bool menuUp = false;

    public GameObject templateGrass;

    public GameObject templateBoulder;

    private GameObject currentlySelectedObject;
    // Start is called before the first frame update
    void Start()
    {
        
        //currencyText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Wood = gameHandler.GetComponent<GameHandler>().Wood;
        Metal = gameHandler.GetComponent<GameHandler>().Metal;
        Stone = gameHandler.GetComponent<GameHandler>().Stone;
        Population = gameHandler.GetComponent<GameHandler>().Population;



        woodText.text = Wood.ToString();
        popText.text = Population.ToString();
        stoneText.text = Stone.ToString();
        metalText.text = Metal.ToString();

    }

    public void DisplayBuildMenu()
	{
        if(!menuUp)
		{
            buildmenu.SetActive(true);
            menuUp = true;
        }
        else
		{
            buildmenu.SetActive(false);
            menuUp = false;
            Destroy(currentlySelectedObject);
        }
    }

    public void ClickGrassTile()
	{
        currentlySelectedObject = (GameObject)Instantiate(templateGrass, transform.position, Quaternion.identity);
    }
    public void ClickBoulderTile()
    {
        currentlySelectedObject = (GameObject)Instantiate(templateBoulder, transform.position, Quaternion.identity);
    }
}
