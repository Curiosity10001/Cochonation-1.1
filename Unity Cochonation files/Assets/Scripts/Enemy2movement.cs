using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2movement : MonoBehaviour
{
    public Transform _parent;
    public GameObject _bombes;
    public float _speed = 100f;
    public float _Rotationfracture = 0.27f;
    public Rigidbody _rgdbdEnnemy2;

  
    private int _X;
    private int _Z;


    // Start is called before the first frame update

    void Start()
    {
    }

    // Update is called once per frame

    private void Awake()
    {


        _X = Random.Range(-1, 1);
        _Z = Random.Range(-1, 1);
    }

    void Update()
    {
        
        
        for (float _t = 0; _t < 1; _t += (Time.deltaTime/_Rotationfracture)) {
            Quaternion _A = Quaternion.Euler(0, Random.Range(0, 360), 0);
            Quaternion _B = Quaternion.Euler(0, Random.Range(0, 360), 0);
            transform.rotation = Quaternion.Slerp(_A,_B, _t);
        }
      
      
    }
    private void FixedUpdate()
    {    
        _rgdbdEnnemy2.velocity = new Vector3(_X,0,0) * _speed;
    }
}
