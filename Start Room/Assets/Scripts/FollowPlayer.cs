﻿using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [Header("Component")]
    public Transform target;

    private void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y, -10);
    }
}
