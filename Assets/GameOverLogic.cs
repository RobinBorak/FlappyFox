using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverLogic : MonoBehaviour
{

  public GameObject NewHighscoreContainer;
  public TextMeshProUGUI NewHighscoreText;
  public Score Score;

  // Start is called before the first frame update
  void Start()
  {
    gameObject.SetActive(false);
    NewHighscoreContainer.SetActive(false);
    //Listen to KillFoxDelegate
    Fox.killFoxDelegate += GameOver;

  }

  public void RestartGame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

  public void GameOver()
  {
    Debug.Log("Game Over");
    gameObject.SetActive(true);

    if (Score.hasNewHighscore)
    {
      NewHighscoreContainer.SetActive(true);
      NewHighscoreText.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }
    else
    {
      NewHighscoreContainer.SetActive(false);
    }

    Fox.killFoxDelegate -= GameOver;
  }
}
