using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string whichLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Scene1GameStart");
    }

    public void StartCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void StartScreen()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    public void Scene2()
    {
        SceneManager.LoadScene("Scene2Doors");
    }

    public void Ending1()
    {
        SceneManager.LoadScene("End1Discovery");
    }

    public void Ending2()
    {
        SceneManager.LoadScene("End2Trouble");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            SceneManager.LoadScene(whichLevel);
        }
    }
}
