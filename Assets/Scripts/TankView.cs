using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;

    private float movement;
    private float rotation;
    
    public Rigidbody rb;
    
    public Rigidbody GetRigidbody()
    {
        return rb;
    }
    
    public void SetTankController(TankController tankController)
    {
        this.tankController = tankController;
    }

    private void Update()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
        if (movement != 0)
        {
            tankController.Move(movement, 30);
        }
        if (rotation != 0)
        {
            tankController.Rotate(rotation, 20);
        }
    }
}
