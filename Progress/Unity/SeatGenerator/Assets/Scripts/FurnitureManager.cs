using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureManager : MonoBehaviour {

    public GameObject barTable;
    public const float MARGIN_TO_FURNITURE = .3f;
    public const float EXIT_PATH_WIDTH = .5f;
    public int itemAmount;
    public GameObject floor;

    private float leftBorder, rightBorder, topBorder, bottomBorder;
    private Vector3 lastObjectPos;

	// Use this for initialization
	void Start () {

        leftBorder = floor.transform.position.x - floor.transform.localScale.x / 2 + EXIT_PATH_WIDTH;
        rightBorder = floor.transform.position.x + floor.transform.localScale.x / 2 - EXIT_PATH_WIDTH;
        topBorder = floor.transform.position.z + floor.transform.localScale.z / 2 - EXIT_PATH_WIDTH;
        bottomBorder = floor.transform.position.z - floor.transform.localScale.z / 2 + EXIT_PATH_WIDTH;

        var objectsParent = new GameObject();
        objectsParent.name = "ObjectsParent";
        objectsParent.transform.parent = floor.transform;

        var currentObj = Instantiate(barTable);
        //currentObj.transform.parent = objectsParent.transform;
        currentObj.transform.position = floor.transform.position;

        var prevObj = currentObj;

        currentObj = Instantiate(barTable);
        //currentObj.transform.parent = objectsParent.transform;
        currentObj.transform.position = prevObj.transform.position + new Vector3(MARGIN_TO_FURNITURE +
            currentObj.transform.lossyScale.x, 0, 0);

        Vector3 objectsMidPoint = (prevObj.transform.position + currentObj.transform.position) / 2;

        objectsParent.transform.position = objectsMidPoint;
        prevObj.transform.parent = objectsParent.transform;
        currentObj.transform.parent = objectsParent.transform;

        objectsParent.transform.position = floor.transform.position;





    }

    // Update is called once per frame
    void Update () {
		
	}

    void PlaceItems() {
        for (int i = 0; i < itemAmount; i++) {

        }
    }
}
