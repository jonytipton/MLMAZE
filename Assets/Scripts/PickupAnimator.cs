﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupAnimator : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}

//Script makes pickups rotate to look nice.