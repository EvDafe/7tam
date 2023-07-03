using UnityEngine;

public class ShootingButton : PlayerSelecter<Shooter>
{
    public void Shoot()
    {
        Player.Shoot();
    }
}
