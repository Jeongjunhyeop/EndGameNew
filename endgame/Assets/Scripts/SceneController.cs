using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void load_stage1()
    {
        SceneManager.LoadScene("STAGE_1");
    }

    public void end_game()
    {
        Application.Quit();
    }

}
