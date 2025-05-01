using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadLoginScene()
    {
        SceneManager.LoadScene("Login");
    }

    public void LoadRegisterScene()
    {
        SceneManager.LoadScene("Register");
    }
    
    public void LoadPlayerSelection()
    {
        SceneManager.LoadScene("PlayerSelection");
    }
    
    public void LoadStart()
    {
        SceneManager.LoadScene("StartingScene");
    }

    public GameObject gameOverUI;

    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }
}