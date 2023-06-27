using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint bomberTurret;
    public TurretBlueprint arrowLauncher;
    public TurretBlueprint magician;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectBomberTurret()
    {
        Debug.Log("Bomber Turret Selected");
        buildManager.SelectTurretToBuild(bomberTurret);
    }

    public void SelectArrowLauncher()
    {
        Debug.Log("Arrow Launcher Selected");
        buildManager.SelectTurretToBuild(arrowLauncher);
    }

    public void SelectMagician()
    {
        Debug.Log("Magician Selected");
        buildManager.SelectTurretToBuild(magician);
    }

}
