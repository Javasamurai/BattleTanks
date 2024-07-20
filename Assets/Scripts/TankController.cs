using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;
    
    private Rigidbody rb;
    
    public TankController(TankModel tankModel, TankView tankView)
    {
        this.tankModel = tankModel;
        this.tankView = GameObject.Instantiate<TankView>(tankView, Vector3.zero, Quaternion.identity);
        this.tankView.SetTankController(this);
        this.tankModel.SetTankController(this);
        rb = this.tankView.GetRigidbody();
    }

    public void Move(float movement, float speed)
    {
        rb.velocity = tankView.transform.forward * movement * speed;
    }
    public void Rotate(float rotate, float speed)
    {
        Vector3 vector = new Vector3(0, rotate * speed, 0);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
}
