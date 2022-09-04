using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement1 : MonoBehaviour
{
    public Transform _player;
    public Rigidbody _rigidbodyE;
    public float _speed = 50;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
    }

    private void FixedUpdate()
    {
        this.transform.LookAt(_player.transform);
        _rigidbodyE.velocity = transform.forward * _speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
    }
}
