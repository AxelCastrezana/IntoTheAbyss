using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    public GameObject Player;
    public GameObject Enemy;
    public float speed;
    public Transform Cass; 
    [SerializeField] private bool isFollowing = true;
    public Transform player;

    private bool shouldFollow = false;


private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Player entered the trigger zone
            AttackPlayer();
        }
    }
     private void AttackPlayer()
    {
        // Assuming the enemy has a script/component to handle attacks
        EnemyAttack enemyAttack = Enemy.GetComponent<EnemyAttack>();

        if (enemyAttack != null)
        {
            // Trigger the enemy's attack
            enemyAttack.Attack();
        }
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject enemyObject = GameObject.FindWithTag("Enemy");
        Transform enemyTransform = enemyObject.transform;
        enemyTransform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.LookAt(Cass);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

         if(Input.GetKeyDown(KeyCode.P)){

            if(!isFollowing){
                isFollowing=true;
            }
            else{
                isFollowing=false;
            }
        }
        if(isFollowing){
                    Enemy.transform.position = Vector3.MoveTowards(Enemy.transform.position, Player.transform.position, speed);        
        }
    }
}
