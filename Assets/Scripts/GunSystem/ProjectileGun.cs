using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileGun : Gun
{
    [SerializeField] private GameObject projectile;
    //[SerializeField] private Transform nozzle;
    [SerializeField] private float shotDelay;
    private float internalTimer;

    private void Start()
    {
        internalTimer = shotDelay;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && internalTimer >= shotDelay)
        {
            Fire();
            internalTimer = 0;
        }
        TimerCount();
    }
    private void TimerCount()
    {
        if (internalTimer < shotDelay)
        {
            internalTimer += Time.deltaTime;

        }
    }

    public override void Fire()
    {
        base.Fire();
        ProjectileSpawning(projectile, nozzle);
    }

}
