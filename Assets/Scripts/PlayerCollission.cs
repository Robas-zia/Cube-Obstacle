using UnityEngine;

public class PlayerCollission : MonoBehaviour {

    public NewBehaviourScript movement;

	void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        { // the FINDOBJECTOFTYPE code literally just searches te assinged area
          //for a particular script, in this case the GAME manager which you can see open
          //in the tabs above
            movement.enabled = false;
          //pretty much disables the movement after a certain condition is true
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }
}
