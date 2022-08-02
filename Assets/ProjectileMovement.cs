using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    public Rigidbody _Rigidbody;
    public float _speed = 50f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        _Rigidbody.velocity = transform.forward * _speed;
        Destroy(gameObject, 15f);
    }
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Debug.Log(collision.collider.name);

    }

}
