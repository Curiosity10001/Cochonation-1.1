using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmiesSpawn : MonoBehaviour
{
    public GameObject[] _spawnPoints;
    public GameObject _enemies1;
    public GameObject _enemies2;
    public int _maxEnemiesInLvl = 5;

    private int _enemiesNB = 0;
    private float _timer;
    // Start is called before the first frame update
    void Start()
    {
        int _randomNumber = Mathf.RoundToInt(Random.Range(0f, _spawnPoints.Length));
        Object.Instantiate(_enemies1, _spawnPoints[_randomNumber].transform);
        Object.Instantiate(_enemies2, _spawnPoints[_randomNumber].transform);
        _timer = 0.0f;
    }
   
    
    // Update is called once per frame
    void Update()
    {
        if(_enemiesNB <= _maxEnemiesInLvl) 
        {
            int _randomNumber1 = Mathf.RoundToInt(Random.Range(0f, _spawnPoints.Length));
            int _randomNumber2 = Mathf.RoundToInt(Random.Range(0f, _spawnPoints.Length));
            _timer += Time.deltaTime;

            if (_timer >= 3)
            {
                _enemiesNB++;
                Object.Instantiate(_enemies1, _spawnPoints[_randomNumber1].transform);
            }
            if (_timer >= 5)
            {
                _enemiesNB++;
                Object.Instantiate(_enemies2, _spawnPoints[_randomNumber2].transform);
                _timer = 0f;
            }
        }
    }        
}
