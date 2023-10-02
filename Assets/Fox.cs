using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
  public float speed = 1f;
  public Rigidbody2D gameObject;
  public bool isAlive = true;

  public delegate void KillFoxDelegate();
  public static event KillFoxDelegate killFoxDelegate;

  // Start is called before the first frame update
  void Start()
  {
  }

  // Update is called once per frame
  void Update()
  {
    if (!isAlive)
    {
      return;
    }

    // If the player presses the space bar or touches the screen, the fox will jump
    if (Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0)
    {
      gameObject.velocity = new Vector2(0, 5) * speed;
    }

    if (IsOffScreen())
    {
      KillFox();
    }
  }

  void OnCollisionEnter2D(Collision2D other)
  {
    // If the fox collides with a log, the fox will die
    Debug.Log("Fox hit a log");
    KillFox();
  }

  public void KillFox()
  {
    // If the fox dies, the game will end
    Debug.Log("Fox died");
    isAlive = false;
    killFoxDelegate?.Invoke();
  }

  bool IsOffScreen()
  {
    float bottomScreen = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
    // If the fox is off the screen, the fox will die
    if (transform.position.y < bottomScreen - 2)
    {
      Debug.Log("Fox off screen");
      return true;
    }
    return false;
  }
}
