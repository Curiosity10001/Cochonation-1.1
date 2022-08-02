using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody _rigidbodyp;
    public GameObject _projectile;
    public float _speed = 10f;
    public Transform _parent;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical") * _speed ;
        float o = Input.GetAxis("Horizontal") * _speed;
        Quaternion r = Quaternion.LookRotation(new Vector3(o, 0, v));

        _rigidbodyp.velocity = new Vector3(o, 0, v);
        _rigidbodyp.MoveRotation(r);

       if (Input.GetButtonDown("Fire1")){
            
            
              Object.Instantiate(_projectile, _parent);
            
        }
        

    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
    