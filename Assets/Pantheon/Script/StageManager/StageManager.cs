using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadingMypage()
    {
        SceneManager.LoadScene("Mypage");


    }

    public void LoadingSelectStage()
    {
        SceneManager.LoadScene("SelectStage");
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



}