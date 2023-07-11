using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int moveSpeed;
    public Rigidbody2D rigidBody;
    private float horizontal;
    public int health_pts;

    //prefab projectile
    public GameObject bulletPrefab;
    //bullet Spawn here
    public Transform bulletSpawnPoint;
    //speed of bullet
    public float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody= gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        transform.Translate(horizontal, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            GameObject Bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position,Quaternion.identity);
            Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
            rb.velocity = transform.up * bulletSpeed;
        }
    }

}
