using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 60f; // Time in seconds
    public Text timerText;           // UI Text component to display the timer
    private bool timerRunning = true;

    public GameObject raceOverUI;        // Reference to the "Race Over" UI panel
    public GameObject player; 

    // Start is called before the first frame update
    void Start()
    {
      raceOverUI.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        if (timerRunning)
        {
            // Reduce the time remaining every second
            timeRemaining -= Time.deltaTime;

            // If the time is up, stop the timer
            if (timeRemaining <= 0)
            {
                timeRemaining = 0;
                timerRunning = false; // Timer stops when time is 0
                // You can add additional logic to trigger events like game over or race end
            }

            // Update the timer display
            UpdateTimerDisplay();
        }
    }
    
    void UpdateTimerDisplay()
    {
        // Display the timer in minutes:seconds format
        float minutes = Mathf.Floor(timeRemaining / 90);
        float seconds = timeRemaining % 90;
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void ResetTimer(float newTime)
    {
       timeRemaining = newTime;
        timerRunning = true;
    }
 void EndRace()
    {
        // Handle end of race actions here
        
        // Show the "Race Over" UI
        if (raceOverUI != null)
        {
            raceOverUI.SetActive(true);
        }

        // Optionally stop player movement, disable controls, or end the race
        if (player != null)
        {
            // Disable player's controls (assuming you have a script to handle movement)
            player.GetComponent<CarController>().enabled = false;
        }
    }
}
