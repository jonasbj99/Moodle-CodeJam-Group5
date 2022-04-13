using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SwitchToggle3 : MonoBehaviour
{
    [SerializeField] RectTransform uiHandleRectTransform;   
    [SerializeField] Color backgroundActiveColor;
    [SerializeField] Color handleActiveColor;

    Image backgroundImage, handleImage;

    Color backgroundDefaultColor, handleDefaultColor;

    private bool val = false;

    Toggle toggle;  

    Vector2 handlePosition;

    void Start()
    {
        toggle = GetComponent<Toggle>();
        handlePosition = uiHandleRectTransform.anchoredPosition;
        
        backgroundImage = uiHandleRectTransform.parent.GetComponent<Image>();
        handleImage = uiHandleRectTransform.GetComponent<Image>();

        backgroundDefaultColor = backgroundImage.color;
        handleDefaultColor = handleImage.color;

        toggle.onValueChanged.AddListener(OnSwitch);

        bool val = PlayerPrefs.GetInt("pleasekillme3",0) == 1 ? true : false;;
        
        Debug.Log("it has been loaded brother");
        if (val)
        {
            toggle.isOn = true;
        }

        if (toggle.isOn)
            OnSwitch (true) ;
    }

   private void OnSwitch (bool on) {
      //uiHandleRectTransform.anchoredPosition = on ? handlePosition * -1 : handlePosition ; // no anim
      uiHandleRectTransform.DOAnchorPos (on ? handlePosition * -1 : handlePosition, .4f).SetEase (Ease.InOutBack) ;

      //backgroundImage.color = on ? backgroundActiveColor : backgroundDefaultColor ; // no anim
      backgroundImage.DOColor (on ? backgroundActiveColor : backgroundDefaultColor, .6f) ;

      //handleImage.color = on ? handleActiveColor : handleDefaultColor ; // no anim
      handleImage.DOColor (on ? handleActiveColor : handleDefaultColor, .4f) ;
      PlayerPrefs.SetInt("pleasekillme3", on ? 1 : 0);
      Debug.Log("shit saved brother");
      PlayerPrefs.Save();
   }

    void OnDestroy ( )
    {     
        toggle.onValueChanged.RemoveListener(OnSwitch);
    }

}
