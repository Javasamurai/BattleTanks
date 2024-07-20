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

    private void Start()
    {
        Camera camera = Camera.main;
        camera.transform.SetParent(transform);
        camera.transform.localPosition = new Vector3(0, 4, -10);
    }

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
            tankController.Move(movement, tankController.GetTankModel().movement);
        }
        if (rotation != 0)
        {
            tankController.Rotate(rotation, tankController.GetTankModel().rotation);
        }
    }
}
