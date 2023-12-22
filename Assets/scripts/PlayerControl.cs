using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float negativtorqueAmount = -1f;
    [SerializeField] float boost = 30f;
    [SerializeField] float baseSpeed = 10f;
    SurfaceEffector2D surfaceEffector2D;
    Rigidbody2D rb2d;
    bool CanMove = true;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }


    // Update is called once per frame
    void Update()
    {
        if(CanMove){
        RotatePlayer();
        Boost();}

    }

public void DisabledControl()
{
    CanMove = false;
}
    void Boost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boost;
        }

        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(negativtorqueAmount);
        }
    }
}
