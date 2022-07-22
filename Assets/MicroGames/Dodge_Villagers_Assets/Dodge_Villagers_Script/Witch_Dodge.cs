using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch_Dodge : MonoBehaviour

{
    public float speed = 5f;
    public float jumpSpeed = 8f;
    private float direction = 0f;
    private Rigidbody2D player;
    public GameObject Witch;
    public AudioSource Hit;
    private int HitAmount = 0;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();


    }
    
    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Jump") && this.transform.position.y < -4.5f)
        {
            player.velocity = new Vector2(player.velocity.x, jumpSpeed);
        }


    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Villagers"))
        {
            Hit.Play();
            HitAmount++;
            HitLimit();
        }
    }

    void HitLimit()
    {
        if (HitAmount == 3)
        {
            Destroy(this.gameObject);
        }
    }



}


