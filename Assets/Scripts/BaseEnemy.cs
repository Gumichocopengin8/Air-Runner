using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class BaseEnemy {

  protected float _speed;

  public float Speed {
    get => _speed;
    set => _speed -= value;
  }

  public abstract void Move();
}
