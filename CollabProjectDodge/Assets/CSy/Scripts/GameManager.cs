using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    private static GameObject container;
    public static GameObject Container { get => container; }

    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if(instance == null)
            {
                container = new GameObject();
                container.name = "Game Manger";
                instance = container.AddComponent(typeof(GameManager)) as GameManager;

                DontDestroyOnLoad(container);
            }

            return instance;
        }
    }

    public UnityEvent OnGameOver = new UnityEvent();

    void Start()
    {
        Reset();
    }

    private void Reset()
    {
        Debug.Log("Reset");
    }

    void Update()
    {
        
    }

    public void OnPlayerDie()
    {
        OnGameOver.Invoke();
    }
}
