﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public void Remove()
    {
        Destroy(gameObject);
    }
}
