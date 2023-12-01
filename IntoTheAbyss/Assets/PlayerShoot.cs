using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 550;
    public int damage = 10;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bulletPrefab, transform.position + new Vector3(0,0,1)*bulletSpeed, bulletPrefab.transform.rotation);
        }

        // if (Input.GetButtonDown("Fire1"))
        // {
        // var bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        // bullet.GetComponent<Rigidbody>().velocity = firePoint.forward * bulletSpeed;
        // }
    }

    // void Shoot()
    // {



    //     // Bullet bulletScript = bullet.GetComponent<Bullet>();

    //     // if (bulletScript != null)
    //     // {
    //     //     bulletScript.SetDamage(damage);
    //     // }
    // }
}