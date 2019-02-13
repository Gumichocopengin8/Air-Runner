using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour {

  private float speed = 0.1f;

  void Start() {
      
  }

  void Update() {
    this.gameObject.transform.Translate(0, 0, speed);
  }
}
