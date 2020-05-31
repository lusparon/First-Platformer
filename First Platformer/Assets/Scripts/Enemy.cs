using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0) //Объект уничтожается , когда здоровье ниже нуля
            Destroy(gameObject, 1f);
    }
}
