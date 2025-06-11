using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public Vector3 sprintRotationSpeed = new Vector3(0, 180, 0);

    public float speedBoost = 3f;
    public float duration = 5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController playerController = collision.GetComponent<PlayerController>();
        if (playerController != null)
        {
            speedActivatePowerUp(playerController);
        }
    }

    void speedActivatePowerUp(PlayerController playerController)
    {
        Debug.Log("Speed boost pickup worked!");
        playerController.ApplySpeedPowerUp(this);
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.eulerAngles += sprintRotationSpeed * Time.deltaTime;
    }
}