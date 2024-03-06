using UnityEngine;

public class TankModel
{
   private TankController tankController;

   public TankModel()
   {

   }

    private void SetTankCOntroller(TankController _tankController)
    {
        this.tankController = _tankController;
    }
}
