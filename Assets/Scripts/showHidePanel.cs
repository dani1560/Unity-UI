using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showHidePanel : MonoBehaviour
{
    GameObject optionPanel;

    void Start()
    {
        optionPanel = GameObject.Find("OptionWindow");
       
    }

    public void OnClick()
    {
        if(optionPanel.active == false)
        {
            optionPanel.SetActive(true);
        }
        else
        {
            optionPanel.SetActive(false);
        }
    }

 
}
