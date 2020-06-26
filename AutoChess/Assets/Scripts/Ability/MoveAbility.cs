using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAbility : Ability
{
    public float speed = 3.0f;
    public Transform transform;

    public MoveAbility(Transform transform)
    {
        this.transform = transform;
    }
}
