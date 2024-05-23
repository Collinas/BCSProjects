using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedControl : MonoBehaviour
{

    SurfaceEffector2D surfaceEffector2D;

    [SerializeField] float normalSpeed = 10f;
    [SerializeField] float boostSpeed = 50f;

    void Start()
    {
        surfaceEffector2D = GetComponent<SurfaceEffector2D>();
    }

    void Update()
    {
        BoostClass();
    }

    void BoostClass()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Boost pressed");
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = normalSpeed;
        }
    }
}
