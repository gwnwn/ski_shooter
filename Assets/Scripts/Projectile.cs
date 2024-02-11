using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector2 direction;
    [SerializeField] private float lifetime = 3f;

    public void SetDirection(Vector2 direction)
    {
        this.direction = direction;
    }

    private void Start()
    {
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = direction * speed * Time.deltaTime + (Vector2)transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Die")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }

    }


}
