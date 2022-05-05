using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{   //This class is made an Instance.
    public static SoundManager Instance;
    //makes 2 fields in the inspector for AudioSources.
    [SerializeField] private AudioSource _effectsSource, _oceanSource;

    // We check in awake if there is another instance
    void Awake() {
        if (Instance != null) { // if there is then we destroy ourselves and return.
            Destroy(this.gameObject);
            return;
        } // if instance = null, then this soundmanager is made that new instance. 
        Instance = this; // this class is also told not to destroy itself when loading a new scene.
        GameObject.DontDestroyOnLoad(this.gameObject);
    }
    // function for playing sound with a audioclip being passed. 
    public void  PlaySound(AudioClip clip) {
        _effectsSource.PlayOneShot(clip);
        //we pick which source we want the audio to come from.
    }  
    // function to change the volume by passing a float.
    public void ChangeMasterVolume(float value) {
        AudioListener.volume = value;
        //audiolistener's volume is set equal to the value from the slider.
    }
    //function to toggle clicks and toggles audioclips 
    public void ToggleEffects()
    {   //inverts itself from it's current state.
        _effectsSource.mute = !_effectsSource.mute;
    }
    //function to toggle sounds of waves and birds.
        public void ToggleWaves()
    {   //inverts itself from it current state.
        _oceanSource.mute = !_oceanSource.mute;
    }
  
}
