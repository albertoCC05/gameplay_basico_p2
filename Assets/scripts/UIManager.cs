using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    //GameVariables

    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject PausePanel;



    //GameFunctions

    public void HideGameOverPanel()
    {
        gameOverPanel.SetActive(false);
    }
    public void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true);
    }
    public void HidePausePanel()
    {
        PausePanel.SetActive(false);
    }
    public void ShowPausePanel()
    {
        PausePanel.SetActive(true);
    }




    //MainMenuFunctions
    public void StartLevel1()
    {
        SceneManager.LoadScene(0);
    }
    public void StartLevel2()
    {
        SceneManager.LoadScene(1);
    }

    private void Start()
    {
        HideGameOverPanel();
        HidePausePanel();
    }
}
