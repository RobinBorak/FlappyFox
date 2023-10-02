using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSpawner : MonoBehaviour
{

  public GameObject logPrefab;
  public GameObject fox;
  public float spawnRate = 10f;
  float timeSinceLastSpawned = 0f;
  int logsSpawned = 0;


  // Start is called before the first frame update
  void Start()
  {
    timeSinceLastSpawned = spawnRate;
  }

  // Update is called once per frame
  void Update()
  {

    if (fox.GetComponent<Fox>().isAlive == false)
    {
      return;
    }

    if (timeSinceLastSpawned > spawnRate)
    {
      GameObject log = Instantiate(logPrefab);
      log.transform.position = transform.position + new Vector3(0, Random.Range(-5.0f, 5.0f), 0);
      timeSinceLastSpawned = 0f;
      logsSpawned++;

      if (logsSpawned % 2 == 0)
      {
        IncreaseSpawnRate();
      }
    }
    else
    {
      timeSinceLastSpawned += Time.deltaTime;
    }

  }

  void IncreaseSpawnRate()
  {
    spawnRate = this.spawnRate * 0.9f;
  }
}
