using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] public Slider _slider;

    //private float MasterVolume = 0f;


    void Start()
    {   
        _slider.value = PlayerPrefs.GetFloat("gayvolume");     
        _slider.onValueChanged.AddListener(val => SoundManager.Instance.ChangeMasterVolume(val));

    }
    void OnDestroy()
    {
        PlayerPrefs.SetFloat("gayvolume", _slider.value);
        PlayerPrefs.Save();
        Debug.Log("save da volume");
    }


}
