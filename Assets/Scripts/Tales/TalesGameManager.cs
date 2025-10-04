using UnityEngine;
using UnityEngine.UI;

public class TalesGameManager : MonoBehaviour
{
    [Header("Panels")]
    public GameObject panelStartGame;
    public GameObject panelAssembly;
    public GameObject panelNameSelection;
    public GameObject panelAddAnimation;
    public GameObject panelFinal;

    public string _characterName;
    public GameObject _characterModel;

    private void Start()
    {
        ShowStartGame();
    }

    public void ShowStartGame()
    {
        HideAllPanel();
        panelStartGame.SetActive(true);
    }
    public void ShowAssembly()
    {
        HideAllPanel();
        panelAssembly.SetActive(true);
        
    }
    public void ShowNameSelection()
    {
        HideAllPanel();
        panelNameSelection.SetActive(true);
    }
    public void ShowAddAnimation()
    {
        HideAllPanel();
        panelAddAnimation.SetActive(true);
    }
    public void ShowFinal()
    {
        HideAllPanel();
        panelFinal.SetActive(true);
    }
    public void OnNameSelected()
    {

        ShowAddAnimation();
    }
    public void OnAnimationAdded()
    {
        ShowFinal();
    }
    private void HideAllPanel()
    {
        panelStartGame.SetActive(false);
        panelAssembly.SetActive(false);
        panelNameSelection.SetActive(false);
        panelAddAnimation.SetActive(false);
        panelFinal.SetActive(false);
    }








}





