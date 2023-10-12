using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public event Action OnFightEvent;
    public event Action OnActEvent;
    public event Action OnItemEvent;
    public event Action OnMercyEvent;

    public void OnSceneTransition(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OnFight()
    {
        OnFightEvent?.Invoke();
    }

    public void OnAct()
    {
        OnActEvent?.Invoke();
    }

    public void OnItem()
    {
        Debug.Log("미구현");
        OnItemEvent?.Invoke();
    }

    public void OnMercy()
    {
        Debug.Log("미구현");
        OnMercyEvent?.Invoke();
    }
}
