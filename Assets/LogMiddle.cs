using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogMiddle : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.GetComponent<Fox>() != null)
    {
      // Get the score script component
      Score scoreScript = GameObject.Find("Score").GetComponent<Score>();
      // Add 1 to the score
      scoreScript.AddScore(1);
    }
  }
}
