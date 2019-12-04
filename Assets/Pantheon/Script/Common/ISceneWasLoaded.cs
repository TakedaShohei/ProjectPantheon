using UnityEngine;
using UnityEngine.EventSystems;

public interface ISceneWasLoaded : IEventSystemHandler
{
    void OnSceneWasLoaded(object[] arguments);
}