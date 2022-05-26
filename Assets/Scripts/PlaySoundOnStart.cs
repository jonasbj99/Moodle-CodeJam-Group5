using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnStart : MonoBehaviour
{   //makes a field in the inspector for 2 audioclips.
    [SerializeField] private AudioClip _clip, _clip2;

    public void ClickEffect()
    {   //calls the PlaySound function on the SoundManager
        SoundManager.Instance.PlaySound(_clip);
        //A audioclip is also given from the field in the top.
    }
    // another function which does the same but with a different audioclip
    public void ToggleEffect()
    {
        SoundManager.Instance.PlaySound(_clip2);
    }

}
