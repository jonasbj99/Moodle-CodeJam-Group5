using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavigationIcons : MonoBehaviour
{
    [SerializeField] GameObject markedSprite;
    [SerializeField] GameObject targetPanel;

    public void Update()
    {
        if (targetPanel.active)
        {
        
            markedSprite.SetActive(true);
        }
        else
        {
            markedSprite.SetActive(false);
        }
    }
}
