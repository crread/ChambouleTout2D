using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart_Script : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
