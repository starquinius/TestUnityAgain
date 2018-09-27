using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

    /// <summary>
    /// Starts the first track of the game
    /// </summary>
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
}
