using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : BaseEnemy {

  public override void Move() {
    this.gameObject.transform.Translate(0, Speed, 0);
  }

  void Start() {

  }

  void Update() {
    Move();
  }
}
