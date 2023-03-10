using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text scoreText;
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        scoreText.text = score.ToString() + " SCORE";
    }

    public void RestartButton() 
    {
        SceneManager.LoadScene("_Scene_0");
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MainScreen");
    }
}
