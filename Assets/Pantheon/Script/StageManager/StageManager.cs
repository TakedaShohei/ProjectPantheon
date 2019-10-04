﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{

  

    public void LoadingMypage()
    {
        SceneManager.LoadScene("Mypage");
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


}