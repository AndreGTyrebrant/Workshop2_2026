using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwap : MonoBehaviour
{
    public void ChangeToLevel1()
    {
        SceneManager.LoadScene ("First Level");
    }

    public void ChangeToLevel2()
    {
        SceneManager.LoadScene ("Second Level");
    }

    public void ChangeToStart()
    {
        SceneManager.LoadScene ("Start");
    }
}
