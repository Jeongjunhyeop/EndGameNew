using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public void load_main()
    {
        SceneManager.LoadScene("TITLE");
    }

    public void select_stage()
    {
        SceneManager.LoadScene("Stage_select");
    }

    public void load_stage1()
    {
        SceneManager.LoadScene("STAGE_1");
    }

    public void load_stage2()
    {
        SceneManager.LoadScene("STAGE_2");
    }

    public void load_stage3()
    {
        SceneManager.LoadScene("STAGE_3");
    }

    public void load_stage4()
    {
        SceneManager.LoadScene("STAGE_4");
    }

    public void end_game()
    {
        Application.Quit();
    }

}
