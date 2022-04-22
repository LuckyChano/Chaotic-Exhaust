﻿using UnityEngine;
using System.Collections;

public interface IWalkable
{
    void Move();

    void Jump();
}
public interface IsShootable
{
    void Damage(int damage);
    void DamageFeedback();
}
public interface IPickable
{
    GameObject ReturnObject();
}


