using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* inspiration taken from: https://www.youtube.com/watch?v=wpSm2O2LIRM , Alexander Zotov, Unity Tutorial
 * How Control And Move Gameobject With Accelerometer or Gyroscope in Android Game, April 6th 2022
*/

public class movement : MonoBehaviour
{
    Rigidbody2D rb;
    float dirx;
    float moveSpeed = 80f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dirx = Input.acceleration.x * moveSpeed;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, 12f, 380f), transform.position.y);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirx, 0f);
    }
}
