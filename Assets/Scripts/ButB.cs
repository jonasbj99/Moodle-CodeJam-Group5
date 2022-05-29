using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButB : ButA
{
    public void SwapOnClick()
    {
        temporaryPosition = ButtonC.transform.position;

        ButtonC.transform.position = ButtonB.transform.position;

        ButtonB.transform.position = temporaryPosition;

    }

}
