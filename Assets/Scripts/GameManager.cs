using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// THIS IS THE GAME MANAGER
/// </summary>
public class GameManager : MonoBehaviour {

    bool GameHasEnded = false;
    // I had to make a boolean to tell the computer whether the game has ended or not
    public float restartDelay = 1f;
    //this is the time(f is just a float variable, look it up on Google) of 1 second
    public GameObject CompleteLevelUI;
    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if(GameHasEnded == false) //this part is pretty understandable I suppose
        {
            GameHasEnded = true;
            Debug.Log("Game over!");
            //the Invoke funtion is like what the word means in real life, 
            //something has to INVOKE the function to run it
            Invoke("restart",restartDelay);
        }
        
    }
	/// <summary>
    /// this is the part of the code which decides what to do when the game restarts
    /// </summary>
    void restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
