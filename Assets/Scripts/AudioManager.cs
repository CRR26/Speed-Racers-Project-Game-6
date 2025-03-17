using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
   private static AudioManager instance;

    void Awake()
    {
        // If there's already an instance of this object, destroy the new one
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            // Make this object persist across scene loads
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
