using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButA : MonoBehaviour
{
    // the following video was used as a tutorial for the amount of code https://www.youtube.com/watch?v=bz2OIW3jMvA 
    // The Gameobjects and Vector2 was defined in this script, and the 2 other scripts replicating this but for their own button inherited this script

    public GameObject ButtonA;
    public GameObject ButtonB;
    public GameObject ButtonC;

    public Vector2 temporaryPosition;


    public void SwapOnClick()
    {   
            temporaryPosition = ButtonB.transform.position;

            ButtonB.transform.position = ButtonA.transform.position;

            ButtonA.transform.position = temporaryPosition;
        
    }


}
