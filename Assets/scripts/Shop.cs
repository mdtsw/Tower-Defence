using UnityEngine;

public class Shop : MonoBehaviour
{
    public turretblueprint standardturret;
    public turretblueprint missilelauncher;
    public turretblueprint lanceFlamme;
    private BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }


   public void SelectStandardTurret()
    {
        buildManager.SelectTurretToBuild(standardturret);
    }
   public void SelectMissileLauncher()
   {
       buildManager.SelectTurretToBuild(missilelauncher);
   }
    public void SelectLanceFlamme()
    {
        buildManager.SelectTurretToBuild(lanceFlamme);
    }
}
