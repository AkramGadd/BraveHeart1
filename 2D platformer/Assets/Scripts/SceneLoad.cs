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
}