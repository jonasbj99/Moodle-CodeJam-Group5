using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButC : ButA
{
    public void SwapOnClick()
    {
        temporaryPosition = ButtonA.transform.position;

        ButtonA.transform.position = ButtonC.transform.position;

        ButtonC.transform.position = temporaryPosition;

    }

}
