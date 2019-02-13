using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileSpawner : MonoBehaviour {

  public GameObject missleSpawner;

  void Start() {

  }

  void Update() {
    if (Input.GetKeyDown(KeyCode.A)) {
      Spawn();
    }
  }

  public void Spawn() {
    Vector3 offset = new Vector3(0.8f, 0, 0);
    Instantiate(missleSpawner, transform.position + offset, transform.rotation);
  }
}
