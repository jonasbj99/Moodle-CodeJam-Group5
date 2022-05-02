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
        _slider.value = PlayerPrefs.GetFloat("megavolume");     
        _slider.onValueChanged.AddListener(val => SoundManager.Instance.ChangeMasterVolume(val));

    }
    void OnDestroy()
    {
        PlayerPrefs.SetFloat("megavolume", _slider.value);
        PlayerPrefs.Save();
        Debug.Log("volume saved");
    }


}
