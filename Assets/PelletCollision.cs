﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletCollision : MonoBehaviour
{
    private void OnCollisionStay2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}