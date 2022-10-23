using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public bool isDead;
    public float velocity=1f;

    public Rigidbody2D rb2D;

    public GameManager managerGame;

    public GameObject DeathScreen;

    private void Start()
    {
        Time.timeScale = 1;
    }
    
    void Update()
    {// tiklamayi al
        if (Input.GetMouseButtonDown(0))
        {
            // havada gemiyi sicrat
            rb2D.velocity = Vector2.up * velocity;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name== "score area")
        {
            managerGame.UpdateScore();
        }
    }

   private void OnCollisionEnter2D (Collision2D collision)
    {
        if(collision.gameObject.tag == "Death Area")
        {
            isDead = true;
            Time.timeScale = 0;

            DeathScreen.SetActive(true);
        }
    }

}
