using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenu : MonoBehaviour
{
    public string _mainMenu = "MainMenu";


    public void ReturnToMainMenuScene()
    {
        Debug.Log("Тык-Тык");
        SceneManager.LoadScene(_mainMenu);
    }



}
