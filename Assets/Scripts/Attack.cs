using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;

public class Attack : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private Transform muzzle;
    private Vector2 direction;

    public static int bulletNum = 3;
    public TextMeshProUGUI bulletText;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && bulletNum > 0)
        {
            GameObject temp = Instantiate(projectile, muzzle.position, Quaternion.identity);
            temp.GetComponent<Projectile>().SetDirection(direction);
            bulletNum--;
        }
        bulletText.text = "Bullet: " + bulletNum;
        direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        direction = direction.normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}