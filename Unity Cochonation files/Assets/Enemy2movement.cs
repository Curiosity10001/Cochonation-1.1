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

    private Transform _ArenaSide1X;
    private Transform _ArenaSide2X;
    private Transform _ArenaSide3Z;
    private Transform _ArenaSide4Z;
    private float _X;
    private float _Z;


    // Start is called before the first frame update

    void Start()
    {
        _ArenaSide1X = GameObject.FindGameObjectWithTag("WALL1").transform;
        _ArenaSide2X = GameObject.FindGameObjectWithTag("WALL2").transform;
        _ArenaSide3Z = GameObject.FindGameObjectWithTag("WALL3").transform;
        _ArenaSide4Z = GameObject.FindGameObjectWithTag("WALL4").transform;
    }

    // Update is called once per frame

    private void Awake()
    {
        _X = Random.Range(_ArenaSide1X.position.x + 5, _ArenaSide2X.position.x - 5);
        _Z = Random.Range(_ArenaSide3Z.position.z + 5, _ArenaSide4Z.position.z - 5);

        for (float _t = 0; _t < 1; _t += (Time.deltaTime / _Rotationfracture))
        {
            Object.Instantiate(_bombes, _parent);
        }
            
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
        _rgdbdEnnemy2.velocity = new Vector3(_X,0,_Z) * _speed* Time.deltaTime;
    }
}
