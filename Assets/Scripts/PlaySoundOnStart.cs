using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnStart : MonoBehaviour
{
    [SerializeField] private AudioClip _clip, _clip2;

    public void ClickEffect()
    {
        SoundManager.Instance.PlaySound(_clip);
        
    }

    public void ToggleEffect()
    {
        SoundManager.Instance.PlaySound(_clip2);
    }

}
