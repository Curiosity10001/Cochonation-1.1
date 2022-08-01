using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    public Rigidbody _Rigidbody;
    public float _speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        _Rigidbody.velocity = transform.forward * _speed;
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Debug.Log("collision bullet !! ");
    }
}
