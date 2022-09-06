using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawn : MonoBehaviour
{
    public GameObject _enemies1;
    public GameObject _enemies2;
    public int _maxEnemiesInLvl = 5;


    private Transform _ArenaSide1X;
    private Transform _ArenaSide2X;
    private Transform _ArenaSide3Z;
    private Transform _ArenaSide4Z;
    private int _enemiesNB = 0;
    private float _timer;
    private float _X;
    private float _Z;
    // Start is called before the first frame update
    void Start()
    {
        _ArenaSide1X = GameObject.FindGameObjectWithTag("WALL1").transform;
        _ArenaSide2X = GameObject.FindGameObjectWithTag("WALL2").transform;
        _ArenaSide3Z = GameObject.FindGameObjectWithTag("WALL3").transform;
        _ArenaSide4Z = GameObject.FindGameObjectWithTag("WALL4").transform;

        _X = Random.Range(_ArenaSide1X.position.x, _ArenaSide2X.position.x);
        _Z = Random.Range(_ArenaSide3Z.position.z, _ArenaSide4Z.position.z);

        Object.Instantiate(_enemies1, new Vector3(_X, 0, _Z),Quaternion.identity);
        Object.Instantiate(_enemies2, new Vector3(_X, 0, _Z), Quaternion.identity);
        _timer = 0.0f;
    }
   
    
    // Update is called once per frame
    void Update()
    {
        if(_enemiesNB <= _maxEnemiesInLvl) 
        {
            
            _timer += Time.deltaTime;

            if (_timer >= 3)
            {
               _X = Random.Range(_ArenaSide1X.position.x, _ArenaSide2X.position.x);
               _Z = Random.Range(_ArenaSide3Z.position.z, _ArenaSide4Z.position.z);
                Object.Instantiate(_enemies1, new Vector3(_X, 0, _Z), Quaternion.identity);
                _enemiesNB++;
            }
            if (_timer >= 5)
            {
                _X = Random.Range(_ArenaSide1X.position.x, _ArenaSide2X.position.x);
                _Z = Random.Range(_ArenaSide3Z.position.z, _ArenaSide4Z.position.z);
                Object.Instantiate(_enemies2, new Vector3(_X, 0, _Z), Quaternion.identity);
                _enemiesNB++;
                _timer = 0f;
            }

        }
    }        
}
