using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    void Start()
    {
        Instantiate(enemy,new Vector3(rand(), 1, rand()),Quaternion.identity);
        Instantiate(enemy,new Vector3(rand(), 1, rand()),Quaternion.identity);
        Instantiate(enemy,new Vector3(rand(), 1, rand()),Quaternion.identity);
        Instantiate(enemy,new Vector3(rand(), 1, rand()),Quaternion.identity);
        Instantiate(enemy,new Vector3(rand(), 1, rand()),Quaternion.identity);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int rand() { 
    
    return Random.Range(-12,12);
    
    }
        
        
        
        }
