using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{

    

  
    public void LoadingMypage()
    {
        SceneManager.LoadScene("Mypage");
    }
    public void LoadingRecollection()
    {
        SceneManager.LoadScene("Recollection");
    }

    public void LoadingMainStory()
    {
        SceneManager.LoadScene("MainStory");
    }
    public void LoadingStage2Scene()
    {
        SceneManager.LoadScene("stage2");
    }
    public void LoadingGameOverScene()
    {
        SceneManager.LoadScene("gameover");

    }
    public void LoadingClearScene()
    {
        SceneManager.LoadScene("clear");

    }
    public void LoadingBaseSelect()
    {
        SceneManager.LoadScene("BaseSelect");
    }
    public void LoadingSelectStage4()
    {
        SceneManager.LoadScene("SelectStage4");
    }
    public void LoadingSelectStage()
    {
        SceneManager.LoadScene("SelectStage");
    }

    public void LoadingBattle()
    {
        SceneManager.LoadScene("Battle");
    }
    public void LoadingOption()
    {
        SceneManager.LoadScene("Option");
    }

}