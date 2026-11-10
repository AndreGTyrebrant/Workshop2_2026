using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwap : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
    }
}
