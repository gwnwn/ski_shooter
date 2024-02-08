using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private Transform muzzle;
    [SerializeField] private Vector2 shootDirection = Vector2.left;
    [SerializeField] private float shootInterval = 2f;

    private float shootTimer;

    private void Start()
    {
        shootDirection = shootDirection.normalized;
        shootTimer = shootInterval;
    }

    // Update is called once per frame
    void Update()
    {
        shootTimer -= Time.deltaTime;
        if (shootTimer <= 0)
        {
            Shoot();
            shootTimer = shootInterval;
        }
    }

    void Shoot()
    {
        GameObject temp = Instantiate(projectile, muzzle.position, Quaternion.identity);
        temp.GetComponent<Projectile>().SetDirection(shootDirection);

        //float angle = Mathf.Atan2(shootDirection.y, shootDirection.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
