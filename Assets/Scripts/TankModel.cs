using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    private TankController tankController;
    public float movement;
    public float rotation;
    public TankType tankType;
    public Material material;

    public enum TankType
    {
        BLUE,
        RED,
        GREEN
    }
    
    public TankModel(float movement, float rotation, TankType tankType, Material material)
    {
        this.movement = movement;
        this.rotation = rotation;
        this.tankType = tankType;
        this.material = material;
    }
    
    public void SetTankController(TankController tankController)
    {
        this.tankController = tankController;
    }
}
