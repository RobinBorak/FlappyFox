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

  // Start is called before the first frame update
  void Start()
  {

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
}
