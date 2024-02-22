using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    //GameVariables
    private int score = 0;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject PausePanel;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI totalScore;

   



    //GameFunctions
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(2);
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void LoadGame()
    {
        Time.timeScale = 1;
    }
    public void updateScore()
    {
        score++;
        scoreText.text = $"Score: {score}";
    }

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
    public void TotalScoreTextUpdate()
    {
        totalScore.text = $"Total Score {score}";
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
