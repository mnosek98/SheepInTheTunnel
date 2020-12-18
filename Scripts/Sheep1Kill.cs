using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep1Kill : MonoBehaviour
{
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    public float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        movement = direction;
        direction.Normalize();


        Debug.Log(direction);
        KillPlayer();
    }

    private void FixedUpdate()
    {
        moveEnemy(movement);
        //KillPlayer();
    }

    void moveEnemy(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    void KillPlayer()
    {
        RaycastHit2D collide = Physics2D.Raycast(player.position, player.right);

        if (collide)
        {
            Player player = collide.transform.GetComponent<Player>();
            if (player != null)
            {
                player.TakeDamage(1);
                Debug.Log(player.currentHealth);
            }
        }
    }
}
