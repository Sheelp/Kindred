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
        spawnPos = new Vector2(Mathf.Round(mousePos.x), Mathf.Round(mousePos.y));



        if (Input.GetMouseButtonDown(1) && isAnObjectSelected == true)
        {
            Destroy(currentlySelectedObject);
            isAnObjectSelected = false;
            selectedObjectInArray = 0;
        }



    }

    public void SpawnGrass()
    {
        Destroy(currentlySelectedObject);
        selectedObjectInArray = 0;
        currentlySelectedObject = (GameObject)Instantiate(selectableObjects[selectedObjectInArray], spawnPos, Quaternion.identity);
        isAnObjectSelected = true;
    }
    public void SpawnRock()
    {
        Destroy(currentlySelectedObject);
        selectedObjectInArray = 1;
        currentlySelectedObject = (GameObject)Instantiate(selectableObjects[selectedObjectInArray], spawnPos, Quaternion.identity);
        isAnObjectSelected = true;
    }
    public void spawnForest()
    {
        Destroy(currentlySelectedObject);
        selectedObjectInArray = 2;
        currentlySelectedObject = (GameObject)Instantiate(selectableObjects[selectedObjectInArray], spawnPos, Quaternion.identity);
        isAnObjectSelected = true;
    }
    public void spawnHouse()
    {
        Destroy(currentlySelectedObject);
        selectedObjectInArray = 3;
        currentlySelectedObject = (GameObject)Instantiate(selectableObjects[selectedObjectInArray], spawnPos, Quaternion.identity);
        isAnObjectSelected = true;
    }
    public void spawnLoggingCabin()
    {
        Destroy(currentlySelectedObject);
        selectedObjectInArray = 4;
        currentlySelectedObject = (GameObject)Instantiate(selectableObjects[selectedObjectInArray], spawnPos, Quaternion.identity);
        isAnObjectSelected = true;
    }
    public void spawnMine()
    {
        Destroy(currentlySelectedObject);
        selectedObjectInArray = 5;
        currentlySelectedObject = (GameObject)Instantiate(selectableObjects[selectedObjectInArray], spawnPos, Quaternion.identity);
        isAnObjectSelected = true;
    }
}
