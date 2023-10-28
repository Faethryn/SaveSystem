using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    public UnityEvent loadLevelEvent;
    
    // Start is called before the first frame update
    private void Awake()
    {
        current = this;
        
    }

    
    public void LoadLevel(string nextLevel)
    {
        SceneManager.LoadSceneAsync(nextLevel);
        loadLevelEvent.Invoke();
    }

}
