using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

  public GameObject player;
  private Vector3 offset;

  void Start() {
    offset = transform.position - player.transform.position;
  }

  void Update() {
    transform.position = new Vector3(player.transform.position.x + offset.x, offset.y, offset.z);
  }
}