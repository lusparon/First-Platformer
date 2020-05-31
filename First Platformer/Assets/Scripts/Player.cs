using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 direction;
    public float speed;
    private float horizontal;
    private bool right; // повернут ли игрок вправо ?

    public GameObject bulletPref;
    public Transform gunPos;


    void Start()
    {
        speed = 3;
        
    }

    private void Shoot()
    {
        GameObject temp = Instantiate(bulletPref, gunPos.position, Quaternion.identity);
        temp.name = "Bullet";
        temp.GetComponent<Bullet>().direction = (!right) ? 1 : -1;
    }

    private void Move()
    {
        if (horizontal > 0 && right)
        {
            Flip();
        }
        else if (horizontal < 0 && !right)
        {
            Flip();
        }
        direction = Vector3.right * horizontal;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
    }

    private void Flip()
    {
        right = !right;  //меняем сторону
        Vector2 sc = transform.localScale; // временный вектор для хранения Scale
        sc.x *= -1; // Изменили scale , чтобы поворнуть игрока
        transform.localScale = sc;
    }
    
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        if (Input.GetButton("Horizontal"))
        {
            Move();
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
            Shoot();
    }

}
