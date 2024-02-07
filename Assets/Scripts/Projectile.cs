using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector2 direction;

    public void SetDirection(Vector2 direction)
    {
        this.direction = direction;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = direction * speed * Time.deltaTime + (Vector2)transform.position;
    }
}
