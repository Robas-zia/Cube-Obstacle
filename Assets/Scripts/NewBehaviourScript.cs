using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    //this creates a reference to the physics engine RigidBody
    public Rigidbody rb;

    //create a z-axis variable
    public float ForwardForce = 2000f;

    //create a speed control, on the z-axis variable
        public float SidewaysForce = 500f;

	
	// Update is called once per frame
    // FixedUpdate is best for interacting with the physics engine, but not for things that require immediate effect

	void FixedUpdate () {
        rb.AddForce(0, 0, ForwardForce*Time.deltaTime); //time.deltaTime makes sure the frame rates don't mess up the gameplay
                                                        //ForwardForce is force on the z-axis, the axises are x, y, z                       
        if (Input.GetKey("d")) //if the user presses the key D then the Player moves to the right
        {
            rb.AddForce(SidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) //if the user presses the key A then the Player moves to the left
        {
            rb.AddForce(-SidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //this is new
        //basically means that if the position of 'rb' which is our player is -1 on the 
        // z -axis, then report that position to the "game manager" which controls
        // the gameplay
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}