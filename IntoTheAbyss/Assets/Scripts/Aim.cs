using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{

    Animator anim1;
    
    // Start is called before the first frame update
    void Start()
    {
        Animator anim1 = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetMouseButtonDown(0))
    {
        
        anim1.SetTrigger("Attack");
    }
    }
}
