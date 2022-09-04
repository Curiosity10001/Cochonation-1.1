using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody _rigidbodyp;
    public GameObject _projectile;
    public float _speed = 0.25f;
    public Transform _parent;
    float _vertical;
    float _orizontal;
    Quaternion _rotation;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       if (Input.GetButtonDown("Fire1")){
            
            
              Object.Instantiate(_projectile, _parent);
            
        }  
    }
    private void FixedUpdate()
    {
        _vertical = Input.GetAxisRaw("Vertical");
        _orizontal = Input.GetAxisRaw("Horizontal");
        _rotation = Quaternion.LookRotation(new Vector3(_orizontal, 0, _vertical));

        _rigidbodyp.velocity = new Vector3(_orizontal, 0, _vertical) * _speed;
        _rigidbodyp.MoveRotation(_rotation);
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
    