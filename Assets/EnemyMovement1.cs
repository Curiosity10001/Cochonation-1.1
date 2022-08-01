using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement1 : MonoBehaviour
{
    public Transform _player;
    public Rigidbody _rigidbodyE;
    public GameObject Bombes;
    public float _speed = 50;
    public Transform _parent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(_player.transform);
        _rigidbodyE.velocity= transform.forward*_speed;
        
        Object.Instantiate(Bombes, _parent);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision Enemy !! ");
    }
}
