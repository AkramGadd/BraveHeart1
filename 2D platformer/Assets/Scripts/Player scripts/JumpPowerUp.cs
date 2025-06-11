using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPowerUp : MonoBehaviour
{
    public Vector3 sprintRotationSpeed = new Vector3(0, 180, 0);
    public float jumpBoost = 5f;
    public float duration = 10f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController playerController = collision.GetComponent<PlayerController>();
        if (playerController != null)
        {
            ActivatePowerUp(playerController);
        }
    }

    void ActivatePowerUp(PlayerController playerController)
    {
        Debug.Log("Strength boost pickup worked!");
        playerController.ApplyJumpPowerUp(this);
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.eulerAngles += sprintRotationSpeed * Time.deltaTime;
    }
}