using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialFinish : MonoBehaviour
{
    private AudioSource finishTutorialSound;

    private bool levelCompleted = false; //to ensure that the finish sound only plays once
    private void Start()
    {
        finishTutorialSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted)
        {
            finishTutorialSound.Play(); //finish audio 
            levelCompleted = true;
            Invoke("Completelevel", 2f);

        }
    }

    private void Completelevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); //to load main menu from tutorial
    }
}
