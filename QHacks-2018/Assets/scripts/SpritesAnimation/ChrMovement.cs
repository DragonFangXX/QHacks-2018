﻿using UnityEngine;
using System.Collections;

public class ChrMovement : MonoBehaviour
{

    public Transform target;
    public float moveSpeed = 3;

    void Start()
    {
        target = GameObject.Find("Person").transform;
    }

    void Update()
    {
        Chase();
    }

    void Chase()
    {
        Vector3 targetDirection = target.position - transform.position;
        transform.position += targetDirection * moveSpeed * Time.deltaTime;
    }
}