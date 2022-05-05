using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] public Slider _slider;
    // makes a field for the slider which is used to control volume value.


    void Start()
    {   // soundmanager is passed the value which is used to change the master volume.
        SoundManager.Instance.ChangeMasterVolume(_slider.value);
        _slider.onValueChanged.AddListener(val => SoundManager.Instance.ChangeMasterVolume(val));
        // adds a listener which allows to volume from the audiosource to follow
        // the current value of the slider. 
    }
}
