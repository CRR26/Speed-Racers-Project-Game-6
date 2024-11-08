using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    
     public void NextScene([SerializeField] string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
