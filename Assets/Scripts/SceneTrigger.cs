using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneTrigger : MonoBehaviour
{
    public string sceneToLoad;

   private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CMVcam"))
        {
            Debug.Log("Camera entered trigger zone. Loading scene: " + sceneToLoad);
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    
}
