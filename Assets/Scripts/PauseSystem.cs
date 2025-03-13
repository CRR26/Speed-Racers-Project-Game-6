using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSystem : MonoBehaviour
{
    private bool isPaused = false;

    // This function is called when the Pause Button is clicked
    public void TogglePause()
    {
        if (isPaused)
        {
            // Resume the game
            Time.timeScale = 1f; // Resume the game
        }
        else
        {
            // Pause the game
            Time.timeScale = 0f; // Pause the game
        }

        // Toggle the isPaused state
        isPaused = !isPaused;
    }
}
