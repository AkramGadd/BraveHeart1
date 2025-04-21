using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int healthRestored = 10;
    public Vector3 sprintRotationSpeed = new Vector3(0, 180, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Damageable damageable = collision.GetComponent<Damageable>();

        if (damageable)
        {
            bool wasHealed = damageable.Heal(healthRestored);

            if (wasHealed) { Destroy(gameObject); }
        }
    }

    private void Update()
    {
        transform.eulerAngles += sprintRotationSpeed * Time.deltaTime;
    }
}
