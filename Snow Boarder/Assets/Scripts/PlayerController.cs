using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount=1f;
    [SerializeField] float boostAmount=30f;
    [SerializeField] float baseSpeed=20f;
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    bool canMove=true;
    void Start()
    {
        rb2d= GetComponent<Rigidbody2D>();
        surfaceEffector2D=FindObjectOfType<SurfaceEffector2D>();
    }

    
    void Update()
    {
        if(canMove){
            RotatePlayer();
            RespondToBoost();
        }       
    }

    void RespondToBoost()
    {
       if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed=boostAmount;
        }
        else{
            surfaceEffector2D.speed=baseSpeed;
        }
    }

    public void DisableControls(){
        canMove=false;
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
