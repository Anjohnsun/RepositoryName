using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerCombat
{
    public static void Shoot(PlayerM player, GameObject bulletPrefab, Transform bulletPoint)
    {
        if (player.AmmoRackFullness > 0)
        {
            GameObject.Instantiate(bulletPrefab, new Vector3(bulletPoint.position.x, bulletPoint.position.y,
                bulletPoint.position.z), bulletPoint.rotation);
            player.AmmoRackFullness--;
        }
    }

    /*public static void Shoot(GameObject bulletPrefab, Transform bulletPoint, GameObject camera)
    {
        GameObject.Instantiate(bulletPrefab, new Vector3(bulletPoint.position.x, bulletPoint.position.y,
            bulletPoint.position.z), bulletPoint.rotation);
        //
        //
        //
    }*/

    public static void Recharge(PlayerM player)
    {
        player.AmmoRackFullness = player.AmmoRackSize;
        //play animation
    }
}
