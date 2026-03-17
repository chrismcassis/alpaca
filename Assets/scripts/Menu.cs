using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private string firstLevelName;
    public void LoadLevel()
    {
        SceneManager.LoadScene(firstLevelName);
    }
    public void ExitGame() { 
    Application.Quit();
    }

}
