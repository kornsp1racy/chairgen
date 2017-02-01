using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeatSpawner : MonoBehaviour {

    public const float TABLE_DIAMETER = .8f;
    public const float SEAT_DIAMETER = .3f;
    public const float TABLE_BORDER_MARGIN = .1f;
    public const float SPAWN_RADIUS = TABLE_DIAMETER / 2 + TABLE_BORDER_MARGIN +
        SEAT_DIAMETER / 2;

    public GameObject seat;
    public int amount;

	// Use this for initialization
	void Start () {
        
        for (int i = 0; i < amount; i++) {
            float deg = i * 2 * Mathf.PI / amount;
            float x = Mathf.Sin(deg) * SPAWN_RADIUS;
            float z = Mathf.Cos(deg) * SPAWN_RADIUS;

            var spawnedSeat = Instantiate(seat);
            spawnedSeat.transform.parent = transform;
            spawnedSeat.transform.localPosition = new Vector3(x, 0, z);
        }
	}
	
	// Update is called once per frame
	void Update () {
        
	}


}
