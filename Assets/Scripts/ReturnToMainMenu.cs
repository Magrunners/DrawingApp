using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenu : MonoBehaviour
{
    public string _mainMenu = "MainMenu";


    public void ReturnToMainMenuScene()
    {
        Debug.Log("���-���");
        SceneManager.LoadScene(_mainMenu);
    }



}
