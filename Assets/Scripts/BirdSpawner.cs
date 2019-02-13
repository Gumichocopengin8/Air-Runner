using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour {

  private float spawnTime = 3.5f;
  private float timer = 0.0f;
  public GameObject birdPrefab;

  void Start() {

  }

  void Update() {
    timer += Time.deltaTime;
    Vector3 offset = new Vector3(50, 0, 0);

    if (timer > spawnTime) {
      Instantiate(birdPrefab, transform.position + offset, transform.rotation);
      timer = 0;
    }
  }
}
