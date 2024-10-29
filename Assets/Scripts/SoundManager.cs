using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SoundManager : MonoBehaviour
{
 
    public Slider mainSlider;
    // Start is called before the first frame update
    void Awake()
    {
       
        AudioListener.volume = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Invoked when the value of the slider changes.
	public void ValueChangeCheck()
	{
        AudioListener.volume = mainSlider.value;
		Debug.Log (mainSlider.value);
	}


}
