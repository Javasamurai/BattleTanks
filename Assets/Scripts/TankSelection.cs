using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    [SerializeField] private TankSpawner tankSpawner;
    public void BlueTankSelected()
    {
        tankSpawner.CreateTank(TankModel.TankType.BLUE);
        this.gameObject.SetActive(false);
    }
    
    public void RedTankSelected()
    {
        tankSpawner.CreateTank(TankModel.TankType.RED);
        this.gameObject.SetActive(false);

    }
    
    public void GreenTankSelected()
    {
        tankSpawner.CreateTank(TankModel.TankType.GREEN);
        this.gameObject.SetActive(false);
    }
}
