using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int maxHealth = 30;
    public int currentHealth;

    public int fallBounds = -20;

    public HealthBar healthbar;

    private Rigidbody2D rb;
    public Transform player;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {

        // For the sake of checking to see if the health bar works, when the space bar is pressed, the player will take damage 
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            TakeDamage(5);
        }

        if(transform.position.y <= fallBounds)
        {
            TakeDamage(100);
        }

        
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);

        if(currentHealth <= 0)
        {
            Debug.Log("PLAYER DEAD");
            GameControls.Kill(this);
            UnityEngine.SceneManagement.SceneManager.LoadScene("End3Death"); //UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
            
        }
    }
}
