using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavigationIcons : MonoBehaviour
{
    // Two serialized GameObjects for icon sprite and app page panel
    [SerializeField] GameObject markedSprite;
    [SerializeField] GameObject targetPanel;

    // Update function with if statement to active and deactivate the icon sprite if the app page panel is active or not
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
