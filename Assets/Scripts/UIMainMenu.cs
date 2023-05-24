using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIMainMenu : MonoBehaviour
{

    [SerializeField] Button StartButton;
    [SerializeField] Button AboutButton;
    [SerializeField] Button ExitButton;

    void Start()
    {
        StartButton.onClick.AddListener(() => buttonCallBack(StartButton));
        AboutButton.onClick.AddListener(() => buttonCallBack(AboutButton));
        ExitButton.onClick.AddListener(() => buttonCallBack(ExitButton));
    }

    private void buttonCallBack(Button buttonPressed)
    {
        if (buttonPressed == StartButton)
        {
            ScenesManager.instance.LoadCrossroad();
        }

        if (buttonPressed == AboutButton)
        {
            ScenesManager.instance.LoadAbout();
        }

        if(buttonPressed == ExitButton)
        {
            {
                #if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
                #endif
                    Application.Quit();
            }
        }
    }
}
