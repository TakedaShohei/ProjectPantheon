using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public static class SceneManagerEx
{
    static public void LoadSceneWithArg(
         string sceneName,
         object argument,
         LoadSceneMode mode)
    {
        UnityAction<Scene, LoadSceneMode> sceneLoaded = default;
        Action removeHandler = () =>
        {
            SceneManager.sceneLoaded -= sceneLoaded;
        };

        sceneLoaded = (loadedScene, sceneMode) =>
        {
            removeHandler();
            foreach (var root in loadedScene.GetRootGameObjects())
            {
                ExecuteEvents.Execute<ISceneWasLoaded>(root, null, (receiver, e) => receiver.OnSceneWasLoaded(argument));
            }
        };

        SceneManager.sceneLoaded += sceneLoaded;
        SceneManager.LoadScene(sceneName, mode);
    }
}