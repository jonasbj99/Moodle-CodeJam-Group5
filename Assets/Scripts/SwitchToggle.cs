using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class SwitchToggle : MonoBehaviour
{   // 3 different fields: 1 for knob on the toggle and 2 for coloring the toggle. 
    [SerializeField] RectTransform uiHandleRectTransform;   
    [SerializeField] Color backgroundActiveColor;
    [SerializeField] Color handleActiveColor;
    // defines a backgroundimage and a handleimage
    Image backgroundImage, handleImage;
    // defines 2 default colors for the handle
    Color backgroundDefaultColor, handleDefaultColor;
    // defines a toggle for the switch
    Toggle toggle;  
    // defines a vector 2 position for the handle/knob. 
    Vector2 handlePosition;

    void Start()
    {   // we get the toggle component for the toggle.
        toggle = GetComponent<Toggle>();
        handlePosition = uiHandleRectTransform.anchoredPosition;
        //handle position is set to the knob's anchored position.
        backgroundImage = uiHandleRectTransform.parent.GetComponent<Image>();
        // background image is given the parent of the knobs image component.
        handleImage = uiHandleRectTransform.GetComponent<Image>();
        // the handle image is given the knob's image component
        backgroundDefaultColor = backgroundImage.color;
        // background default color is set to the color from the backgroundImage
        handleDefaultColor = handleImage.color;
        //handle default color is set to the color from the handle image.
        // adds a listener looking out for a value change in the boolean value.
        toggle.onValueChanged.AddListener(OnSwitch);
        // is the toggle is turned on then OnSwitch is passed a boolean value of true.
        if (toggle.isOn)
            OnSwitch (true) ;
    }
    // the function used for animating the switch. 
   private void OnSwitch (bool on) {
      // uses DG.Tweening in order to change the switch between two states depending on the boolean.
      uiHandleRectTransform.DOAnchorPos (on ? handlePosition * -1 : handlePosition, .4f).SetEase (Ease.InOutBack) ;
        // two different states for the background image is defined and change depended on the boolean value.
      backgroundImage.DOColor (on ? backgroundActiveColor : backgroundDefaultColor, .6f) ;
        // two different states for the knob/handle as well also controlled by the boolean value.
      handleImage.DOColor (on ? handleActiveColor : handleDefaultColor, .4f) ;
   }
    // hooks into the OnDestroy function
    void OnDestroy ( )
    {     // if the object is destroyed, then the RemoveListener function is called for the OnSwitch.
        toggle.onValueChanged.RemoveListener(OnSwitch);
    }

}
