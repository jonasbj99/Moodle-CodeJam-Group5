using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAudio : MonoBehaviour
{
    [SerializeField] private bool _toggleEffects, _toggleWaves;
    // makes two check mark fields in the inspector for controlling which 
    // effect whould be turned of. 

public void Toggle()
{   // if statements checking if bool = true and if it is
    // then the appropriate sound manager function is called.
    if(_toggleEffects) SoundManager.Instance.ToggleEffects();
    if(_toggleWaves) SoundManager.Instance.ToggleWaves();
}

}
