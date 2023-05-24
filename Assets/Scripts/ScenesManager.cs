using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public static ScenesManager instance;

    private void Awake()
    {
        instance = this;
    }

    public enum Scene
    {
        MainMenu,
        Crossroad,
        Tintersection,
        Yintersection,
        About,
        CrossroadSideMenu,
        TSideMenu,
        YSideMenu,

    }


    public void LoadScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public void LoadCrossroad()
    {
        SceneManager.LoadScene(Scene.Crossroad.ToString());
    }

    public void LoadAbout()
    {
        SceneManager.LoadScene(Scene.About.ToString());
    }

    public void LoadNext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadPrevious()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void LoadTintersection()
    {
        SceneManager.LoadScene(Scene.Tintersection.ToString());
    }

    public void LoadYintersection()
    {
        SceneManager.LoadScene(Scene.Yintersection.ToString());
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(Scene.MainMenu.ToString());
    }

    public void LoadCrossroadSideMenu()
    {
        SceneManager.LoadScene(Scene.CrossroadSideMenu.ToString());
    }

    public void LoadTSideMenu()
    {
        SceneManager.LoadScene(Scene.TSideMenu.ToString());
    }

    public void LoadYSideMenu()
    {
        SceneManager.LoadScene(Scene.YSideMenu.ToString());
    }
}
