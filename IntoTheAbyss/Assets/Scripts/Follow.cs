using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    public GameObject Player;
    public GameObject Enemy;
    public float speed;
    public Transform Cass; 



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject enemyObject = GameObject.FindWithTag("Enemy");
        Enemy.transform.position = Vector3.MoveTowards(Enemy.transform.position, Player.transform.position, speed);       
        Transform enemyTransform = enemyObject.transform;
        enemyTransform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.LookAt(Cass);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
    }
}
