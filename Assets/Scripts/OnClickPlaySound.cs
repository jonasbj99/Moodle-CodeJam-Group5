using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class OnClickPlaySound : MonoBehaviour {
	//Defines an array filled with buttons
    public Button[] buttons;
    //makes a field in the inspector for an audioclip
    [SerializeField] private AudioClip _clip;

	void Start () 
    {   // loops through all the buttons
        for (int i = 0; i < buttons.Length; i++)
        {   //get the Button component from the buttons in the array
            Button btns = buttons[i].GetComponent<Button>();
            //adds a listener to the buttons for the TaskOnClick event.
            btns.onClick.AddListener(TaskOnClick);
        }
	}
    // when TaskOnClick is called the soundmanager instance's function PlaySound is called and a audioclip is given. 
	void TaskOnClick(){
		Debug.Log ("A Button has been click and a sound should have played.");
        SoundManager.Instance.PlaySound(_clip);
	}
}