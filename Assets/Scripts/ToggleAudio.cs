using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAudio : MonoBehaviour
{
    [SerializeField] private bool _toggleEffects, _toggleWaves;


public void Toggle()
{
    if(_toggleEffects) SoundManager.Instance.ToggleEffects();
    if(_toggleWaves) SoundManager.Instance.ToggleWaves();
}

}
