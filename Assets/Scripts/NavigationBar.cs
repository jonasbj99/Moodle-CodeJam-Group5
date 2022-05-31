using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// https://www.youtube.com/watch?v=Rfv5M14ZoGY&ab_channel=InfoGamer
public class NavigationBar : MonoBehaviour
{
    // Array of GameObjects called panels
    [SerializeField] GameObject[] panels;

    // Method with for-loop to deactivate every panel and reactivate activePanel
    public void NavigationBarClick(GameObject activePanel)
    {
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(false);
        }
        activePanel.SetActive(true);
    }
}
