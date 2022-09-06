using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement1 : MonoBehaviour
{
    Transform _player;
    public float _speed = 50;
    public Rigidbody _rgdbdEnnemy1;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
       
    }

    // Update is called once per frame
    void Update()
    {  
    }

    private void FixedUpdate()
    {
       transform.LookAt(_player.position);
        _rgdbdEnnemy1.velocity = transform.forward * _speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
    }
}
