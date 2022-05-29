using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* inspiration taken from: https://www.youtube.com/watch?v=wpSm2O2LIRM , Alexander Zotov, Unity Tutorial
 * How Control And Move Gameobject With Accelerometer or Gyroscope in Android Game, April 6th 2022
*/

public class movement : MonoBehaviour
{
    // reference til rigidbody, retningen bølgerne bevæger sig (på x aksen),
    // og hastigheden bølgerne bevæger sig, med variable
    //BEMÆRK!! rigidbody er 2D, da den kun skal bevæge sig på en 2D plan
    Rigidbody2D rb;
    float dirx;
    public float moveSpeed = 80f;


    // Start is called before the first frame update
    void Start()
    {
        //giver rigidbody en component
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // value fra accelerometer input på x aksen * hastigheden
        // linje 31 viser indenfor hvilken ramme bølgerne kan bevæge sig, så bølgerne ikke bevæger sig uendeligt
        dirx = Input.acceleration.x * moveSpeed;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, 400f, 600f), transform.position.y);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirx, 0f);
    }

        public void DisableWaveAnimation()
    {
        this.enabled = !this.enabled;  
    }
}
