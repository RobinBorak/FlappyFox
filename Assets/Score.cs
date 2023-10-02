using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{

  public int score = 0;
  //TextMeshPro scoreText
  public TextMeshProUGUI scoreText;
  public TextMeshProUGUI highscoreText;

  // Start is called before the first frame update
  void Start()
  {
    Fox.killFoxDelegate += SaveHighscore;

    //Get the highscore from the player prefs
    int highscore = PlayerPrefs.GetInt("Highscore", 0);
    if (highscore > 0)
      highscoreText.text = highscore.ToString();
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void AddScore(int score)
  {
    this.score += score;
    scoreText.text = this.score.ToString();
  }

  void SaveHighscore()
  {
    //If the current score is higher than the saved highscore, save it
    if (this.score > PlayerPrefs.GetInt("Highscore", 0))
    {
      PlayerPrefs.SetInt("Highscore", score);
      PlayerPrefs.Save();
    }
  }
}
