using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // For scene management
using UnityEngine.UI; // For Button control

public class PauseMenuController : MonoBehaviour
{
   public GameObject pauseMenu; // Reference to the pause menu panel
    private bool isPaused = false;

    // This function is called when the "Resume" button is clicked
    public void TogglePause()
    {
        if (isPaused)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
    }

    // Pauses the game and shows the pause menu
    private void PauseGame()
    {
        isPaused = true;
        pauseMenu.SetActive(true); // Show the pause menu
        Time.timeScale = 0f; // Stop game time (pause)
        
    }

    // Resumes the game and hides the pause menu
    private void ResumeGame()
    {
        Time.timeScale = 1f; // Resume game time
        isPaused = false;
        pauseMenu.SetActive(false); // Hide the pause menu
    }
}
