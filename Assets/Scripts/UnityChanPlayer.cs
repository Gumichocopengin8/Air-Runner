using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanPlayer : MonoBehaviour {

  private Animator animator;
  private Rigidbody rd;
  private Vector3 velocity;
  private bool onGround = true;
  private float jumpPower = 6.0f;


  void Start() {
    this.rd = GetComponent<Rigidbody>();
    animator = GetComponent<Animator>();
  }

  void Update() {
    this.gameObject.transform.Translate(0, 0, 0.05f); // run to x axis but need write z on code

    if(Input.GetKeyDown(KeyCode.Space) && onGround) { // when press space button
      rd.AddForce(transform.up * jumpPower, ForceMode.VelocityChange);
      animator.SetTrigger("Jump");
    } else if(Input.GetKeyDown(KeyCode.A)) {
      // attack
    }
  }

  void OnCollisionStay(Collision col) {
    if(col.gameObject.tag == "ground") {
      onGround = true;
    }
  }
}
