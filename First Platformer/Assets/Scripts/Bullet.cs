using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = 0.4f; //скорость пули     
    public int damage = 40; // Урон
    public int direction; // Направление

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemy")  // если попали в врага
        {
            GameObject temp = collision.gameObject;
            temp.GetComponent<Enemy>().health -= damage;  //наносим урон
            Destroy(gameObject);  // удаляем пулю

        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject, 3f); //удаляем пулю через 3 секунды
    }

    void Update()
    {
        transform.position += Vector3.right * direction * speed; 
    }
}
