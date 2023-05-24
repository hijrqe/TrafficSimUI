using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIGameMenu : MonoBehaviour
{

    [SerializeField] Button RetToMain;
    [SerializeField] Button NextOption;
    [SerializeField] Button PrevOption;

    void Start()
    {
        
        RetToMain.onClick.AddListener(() => callButton(RetToMain));
        NextOption.onClick.AddListener(() => callButton(NextOption));
        PrevOption.onClick.AddListener(() => callButton(PrevOption));
    }

    private void callButton(Button buttonPressed)
    {
        if (buttonPressed == RetToMain)
        {
            ScenesManager.instance.LoadMainMenu();
        }

        if (buttonPressed == NextOption)
        {
            ScenesManager.instance.LoadNext();
        }
  
        if (buttonPressed == PrevOption)
        {
            ScenesManager.instance.LoadPrevious();
        }

    }
      
    }


