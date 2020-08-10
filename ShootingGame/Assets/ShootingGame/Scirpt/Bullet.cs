using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 8f;
    private void Start()
    {

    }
    void Update()
    {
        transform.position += transform.up * Speed * Time.deltaTime;

        if (transform.position.y > 5 || transform.position.y < -4)
        {
            Destroy(gameObject);
        }
    }
}
