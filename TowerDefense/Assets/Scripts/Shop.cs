using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseBomberTurret()
    {
        Debug.Log("Bomber Turret Selected");
        buildManager.SetTurretToBuild(buildManager.bomberTurretPrefab);
    }

    public void PurchaseArrowLauncher()
    {
        Debug.Log("Arrow Launcher Selected");
        buildManager.SetTurretToBuild(buildManager.arrowLauncherPrefab);
    }

}
