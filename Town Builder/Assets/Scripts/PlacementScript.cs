using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementScript : MonoBehaviour
{
    private int selectedObjectInArray;

    public GameObject currentlySelectedObject;

    public GameObject[] selectableObjects;

    private bool isAnObjectSelected = false;

    Vector2 spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        selectedObjectInArray = 0;
    }

    // Update is called once per frame
    public void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spawnPos = new Vector2(Mathf.Round(mousePos.x),Mathf.Round(mousePos.y));


        
        if (Input.GetMouseButtonDown(1) && isAnObjectSelected == true)
		{
            Destroy(currentlySelectedObject);
            isAnObjectSelected = false;
            selectedObjectInArray = 0;
		}

        if (Input.GetAxis("Mouse ScrollWheel") > 0 && isAnObjectSelected == true)
        {
            selectedObjectInArray++;

            if(selectedObjectInArray > selectableObjects.Length -1)
			{
                selectedObjectInArray = 0;
			}

            Destroy(currentlySelectedObject);
            currentlySelectedObject = (GameObject)Instantiate(selectableObjects[selectedObjectInArray], spawnPos, Quaternion.identity);
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0 && isAnObjectSelected == true)
        {
            selectedObjectInArray--;

            if (selectedObjectInArray < 0)
            {
                selectedObjectInArray = selectableObjects.Length - 1;
            }

            Destroy(currentlySelectedObject);
            currentlySelectedObject = (GameObject)Instantiate(selectableObjects[selectedObjectInArray], spawnPos, Quaternion.identity);
        }
    }

    public void SpawnGrass()
    {
        selectedObjectInArray = 0;
        currentlySelectedObject = (GameObject)Instantiate(selectableObjects[selectedObjectInArray], spawnPos, Quaternion.identity);
        isAnObjectSelected = true; 
    }
    public void SpawnRock()
    {
        selectedObjectInArray = 1;
        currentlySelectedObject = (GameObject)Instantiate(selectableObjects[selectedObjectInArray], spawnPos, Quaternion.identity);
        isAnObjectSelected = true;
    }
}
