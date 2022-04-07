using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationBar : MonoBehaviour
{
    /*
    public GameObject coursePanel;
    public GameObject calenderPanel;
    public GameObject menuPanel;
    */

    [SerializeField] GameObject[] panels;

    /*
    public void CoursePage()
    {
        coursePanel.SetActive(true);
        calenderPanel.SetActive(false);
        menuPanel.SetActive(false);
    }

    public void CalenderPage()
    {
        coursePanel.SetActive(false);
        calenderPanel.SetActive(true);
        menuPanel.SetActive(false);
    }

    public void MenuPage()
    {
        coursePanel.SetActive(false);
        calenderPanel.SetActive(false);
        menuPanel.SetActive(true);
    }
    */

    public void NavigationBarClick(GameObject activePanel)
    {
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(false);
        }
        activePanel.SetActive(true);
    }
}
