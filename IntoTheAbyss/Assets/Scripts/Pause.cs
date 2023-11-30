using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    [SerializeField] private GameObject Canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1) {
                Time.timeScale = 0;
                Canvas.SetActive(true);
            }
            else if (Time.timeScale == 0)
            {
                Canvas.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }
}
