using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemplateScript : MonoBehaviour
{
    

    public GameObject finalObject;

    private Vector2 mousePos;

    public LayerMask allTilesLayer;

    public GameObject placementManager;

    public int Cost;

    private void Start()
    {
        placementManager = GameObject.Find("Placement Manager");
    }
    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(Mathf.Round(mousePos.x), Mathf.Round(mousePos.y));

        if(Input.GetMouseButtonDown(0))
		{
            //

            Vector2 mouseRay = Camera.main.ScreenToWorldPoint(transform.position);
            RaycastHit2D rayHit = Physics2D.Raycast(transform.position, Vector2.zero, Mathf.Infinity, allTilesLayer);
		    
            if(rayHit.collider == null)
			{
                if((GameObject.Find("GameHandler").GetComponent<GameHandler>().Currency - Cost) >= 0)
				{
                    Instantiate(finalObject, transform.position, Quaternion.identity);
                    GameObject.Find("GameHandler").GetComponent<GameHandler>().Currency -= Cost;
                    Destroy(placementManager.GetComponent<PlacementScript>().currentlySelectedObject);
                }
                
            }
        }
    }
}
