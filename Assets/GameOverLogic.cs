using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverLogic : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    gameObject.SetActive(false);
    //Listen to KillFoxDelegate
    Fox.killFoxDelegate += GameOver;

  }

  // Update is called once per frame
  void Update()
  {

  }

  public void RestartGame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

  public void GameOver()
  {
    Debug.Log("Game Over");
    gameObject.SetActive(true);
    Fox.killFoxDelegate -= GameOver;
  }
}
