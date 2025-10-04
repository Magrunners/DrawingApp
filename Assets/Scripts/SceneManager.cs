using UnityEngine;
using UnityEngine.SceneManagement;
public class MaunMenuManager : MonoBehaviour
{
    public string _mainMenu = "MainMenu";
    public string _tales = "Tales";
    public string _autoIndastry = "AutoIndastry";
    public string _designer = "Designer";
    public string _technoMagic = "TechnoMagic";

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(_mainMenu);
    }
    public void LoadTales()
    {
        SceneManager.LoadScene(_tales);
    }
    public void LoadAutoIndastry()
    {
        SceneManager.LoadScene(_autoIndastry);
    }
    public void LoadDesigner()
    {
        SceneManager.LoadScene(_designer);
    }
    public void LoadTechnoMagic()
    {
        SceneManager.LoadScene(_technoMagic);
    }
}
