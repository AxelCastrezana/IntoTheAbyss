using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        // Verifica si el objeto ha perdido toda su salud
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Puedes agregar aquí cualquier lógica que quieras ejecutar cuando el objeto muere
        Destroy(gameObject);
    }
}