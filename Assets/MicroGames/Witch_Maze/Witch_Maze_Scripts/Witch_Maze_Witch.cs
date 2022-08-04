using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch_Maze_Witch : MonoBehaviour

{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    public bool IsMoving;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      //consider using getaxis raw :sunglasses:
            if (Input.GetKey(KeyCode.W))
            {

                transform.Translate(0f, 0.02f * speed * Time.deltaTime, 0f);

            }

            if (Input.GetKey(KeyCode.S))
            {

                transform.Translate(0f, -0.02f * speed * Time.deltaTime, 0f);

            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(0.02f * speed * Time.deltaTime, 0f, 0f);

            }

            if (Input.GetKey(KeyCode.A))
            {

                transform.Translate(-0.02f * speed * Time.deltaTime, 0f, 0.0f);

            }

        }
    }

