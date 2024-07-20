using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;
    
    public TankController(TankModel tankModel, TankView tankView)
    {
        this.tankModel = tankModel;
        this.tankView = tankView;
        this.tankModel.SetTankController(this);
        this.tankView.SetTankController(this);
        GameObject.Instantiate(tankView, Vector3.zero, Quaternion.identity);
    }
}
