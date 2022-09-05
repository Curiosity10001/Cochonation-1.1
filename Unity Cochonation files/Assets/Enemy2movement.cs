using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2movement : MonoBehaviour
{
    public Transform _parent;
    public GameObject _bombes;
    public float _speed = 100f;
    public float _Rotationfracture = 0.27f;
   
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    
    void Update()
    {
        
        Quaternion _A = Quaternion.Euler(0, Random.Range(0, 360), 0);
        Quaternion _B = Quaternion.Euler(0, Random.Range(0, 360), 0);
        for (float _t = 0; _t < 1; _t += (Time.deltaTime/_Rotationfracture)) {
            transform.rotation = Quaternion.Slerp(_A,_B, _t);
        }
      
      
    }
    private void FixedUpdate()
    {

        this.transform.Translate(Vector3. * _speed* Time.deltaTime , Space.World);
    }
}
