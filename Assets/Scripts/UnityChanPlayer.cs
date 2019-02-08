using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanPlayer : MonoBehaviour {

  private Animator animator;
  private Rigidbody rd;
  private Vector3 velocity;
  private bool onGround = true;
  private float jumpPower = 9.0f;
  private float runSpeed = 0.05f;


  void Start() {
    this.rd = GetComponent<Rigidbody>();
    animator = GetComponent<Animator>();
  }

  void Update() {
    this.gameObject.transform.Translate(0, 0, runSpeed); // run to x axis but need write z on code

    print(onGround);
    if(Input.GetKeyDown(KeyCode.Space) && onGround) { // when press space button
      rd.AddForce(transform.up * jumpPower, ForceMode.VelocityChange);
      animator.SetTrigger("Jump");
    } else if(Input.GetKeyDown(KeyCode.A)) {
      // attack
    }
  }

  void OnCollisionEnter(Collision col) {
    onGround |= col.gameObject.tag == "ground";
  }

  void OnCollisionExit(Collision col) {
    onGround = false;
  }
}
