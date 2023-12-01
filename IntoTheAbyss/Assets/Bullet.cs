using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float life=3;

    void Awake(){
        Destroy(gameObject,life);
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
    // private int damage;

    // public void SetDamage(int value)
    // {
    //     damage = value;
    // }

    // void OnTriggerEnter(Collider hitInfo)
    // {
    //     Health health = hitInfo.GetComponent<Health>();

    //     if (health != null)
    //     {
    //         health.TakeDamage(damage);
    //     }

    //     Destroy(gameObject);
    // }
}

