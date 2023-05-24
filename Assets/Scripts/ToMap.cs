using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToMap : MonoBehaviour
{
    public GameObject ToCrossRoad;
    public GameObject ToTint;
    public GameObject ToYint;
    public GameObject ToHome;
    public GameObject GoBack;
    public GameObject RetButton;

    public void toCrossroad()
    {
        ScenesManager.instance.LoadCrossroadSideMenu();
    }

    public void toTint()
    {
        ScenesManager.instance.LoadTSideMenu();
    }

    public void toYint()
    {
        ScenesManager.instance.LoadYSideMenu();
    }

    public void toHome()
    {
        ScenesManager.instance.LoadMainMenu();
    }

    public void goBack()
    {
        ScenesManager.instance.LoadCrossroad();
    }

    public void retButton()
    {
        ScenesManager.instance.LoadMainMenu();
    }
}
