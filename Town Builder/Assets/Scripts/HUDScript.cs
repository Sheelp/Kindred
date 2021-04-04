using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class HUDScript : MonoBehaviour
{

    public static int Currency;

    Text currencyText;

    public TextMeshProUGUI woodText;

    public GameObject buildmenu;

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
        Currency = GameObject.Find("GameHandler").GetComponent<GameHandler>().Currency;
        woodText.text = Currency.ToString();
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
