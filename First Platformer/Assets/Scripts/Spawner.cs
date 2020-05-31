using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    GameObject CurrentEnemy; //текущий враг
    public GameObject enemyPref; // префаб врага

    void Start()
    {
        CurrentEnemy = Instantiate(enemyPref, transform.position, Quaternion.identity); //создаем врага 
    }


    void Update()
    {
        if (CurrentEnemy == null)      //Если враг был уничтожен , создаем нового
            CurrentEnemy = Instantiate(enemyPref, transform.position, Quaternion.identity);
    }
}
