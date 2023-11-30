using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class PlayerCollision : MonoBehaviour
{
[SerializeField] private GameObject gameOverScreen; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                if (Input.GetKeyDown(KeyCode.R))
        {
            ReloadLevel();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            gameOverScreen.SetActive(true);
            Invoke("ReloadLevel", 2f);


        }
    }

        private void ReloadLevel()
    {
        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
