using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class Move : MonoBehaviour {
    public GameObject[] deplacables;
   
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
         var cam = Camera.main.transform.position;
        foreach (var obj in deplacables)
        {
            Moving destination = obj.GetComponent<Moving>();
            Transform transform = obj.transform;

            float distance = obj.transform.position.x-cam.x;
            if (distance < destination.distanceFromPlayer)
            {
                Vector3 objFuturePos = new Vector3(destination.targetX, destination.targetY, destination.targetZ);
                // fade between current position and the target position using lerp
                obj.transform.position = Vector3.Lerp(transform.position, objFuturePos, destination.smoothing * Time.deltaTime);
            }
        }
        
}
}

