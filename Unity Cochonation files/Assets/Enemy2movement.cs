using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2movement : MonoBehaviour
{
    public Transform _parent;
    public GameObject _bombes;
    public float _speed = 50;
    public Rigidbody _rigidbodyE2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Object.Instantiate(_bombes, _parent);
    }
    private void FixedUpdate()
    {
        this.transform.rotation = Random.rotation;
        _rigidbodyE2.velocity = transform.forward*_speed;
    }
}
