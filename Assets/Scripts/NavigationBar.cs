using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationBar : MonoBehaviour
{
    public GameObject coursePanel;
    public GameObject calenderPanel;
    public GameObject menuPanel;

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
}
