using UnityEngine;

public class SceneControler : MonoBehaviour
{
    private bool pause = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }
    public void PauseGame()
    {
        if (pause == false)
        {
            Time.timeScale = 0f;
            pause = true;
        }
        else
        {
            Time.timeScale = 1f;
            pause = false;
        }
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("вышли из игры");
    }
}
