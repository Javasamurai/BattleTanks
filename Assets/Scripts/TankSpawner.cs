using System;
using System.Collections.Generic;
using UnityEngine;
public class TankSpawner : MonoBehaviour
{
    [SerializeField] private TankView tankView;
    [SerializeField] private List<Tank> tanks;

    [Serializable]
    public class Tank
    {
        public float movement;
        public float rotation;
        public TankModel.TankType tankType;
        public Material material;
    }


    private void Start()
    {
        CreateTank();
    }
    
    private void CreateTank()
    {
        TankModel tankModel = new TankModel(tanks[0].movement, tanks[0].rotation, tanks[0].tankType, tanks[0].material);
        TankController tankController = new TankController(tankModel, tankView);
    }
}