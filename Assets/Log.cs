using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : MonoBehaviour
{
  public float speed = 5f;
  float screenLeft = -10f;

  // Start is called before the first frame update
  void Start()
  {
    screenLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
  }

  // Update is called once per frame
  void Update()
  {
    transform.position += Vector3.left * speed * Time.deltaTime;

    //If the log is off the screen on the left, destroy it
    if (transform.position.x < screenLeft - 2)
    {
      Destroy(gameObject);
    }
  }
}
