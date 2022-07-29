using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody _rigidbodyp;
    public GameObject projectile;
    public float _speed = 10f;
    public Transform nose;
    public Transform parent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical") * _speed ;
        float r = Input.GetAxis("Horizontal") * _speed;

        _rigidbodyp.velocity = new Vector3(r, 0, v);

       if (Input.GetButtonDown("Fire1")){
            for (int i = 0; i < 5; i++) 
            {
              Object.Instantiate(projectile ,nose.localPosition ,Quaternion.identity, parent);
            }
        }
       
    }

}
    