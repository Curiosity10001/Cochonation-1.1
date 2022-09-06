using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    public Rigidbody _Rigidbody;
    public float _speed = 100f;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        Destroy(gameObject, 30f);
    }

    private void FixedUpdate()
    {
        _Rigidbody.velocity = transform.forward * _speed;
    }
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("enemy"))
            {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            };
        Destroy(gameObject);

        
    }

}
