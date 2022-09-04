using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2movement : MonoBehaviour
{
    public Transform _parent;
    public GameObject _bombes;
    public float _speed = 100f;
    public Rigidbody _rigidbodyE2;
    public float _rotationSpeed = 50.0f;


    private Quaternion _Rotationdirection;
    private float _rotationTimer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _rotationTimer += Time.deltaTime;
        Object.Instantiate(_bombes, _parent);

        if (_rotationTimer > 1)
        {
            transform.rotation = Quaternion.Slerp(Random.rotation, Random.rotation, _rotationTimer);
            _rotationTimer = 0.0f;
        }
    }
    private void FixedUpdate()
    {
      
        _rigidbodyE2.velocity = transform.forward * _speed;
    }
}
