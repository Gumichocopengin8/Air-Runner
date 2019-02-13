using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class BaseEnemy : MonoBehaviour {

  protected float _speed = 0.01f;

  public float Speed {
    get => _speed;
    set => _speed -= value;
  }

  public abstract void Move();
}
