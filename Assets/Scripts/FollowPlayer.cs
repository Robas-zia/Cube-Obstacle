using UnityEngine;

// for the camera tracking
public class FollowPlayer : MonoBehaviour {

    //creates a variable called player, following the Transform variable   
    public Transform player;
    //creates a offset called offset, so the camera tracks not from INSIDE the object, but slightly behind it
    public Vector3 offset;
	
	// Update is called once per frame
	void Update () { //this adds the PLAYERS current coordinates in x, y and z, and adds to it the OFFSET variable
                     //create above
        transform.position = player.position + offset;
	}
}
