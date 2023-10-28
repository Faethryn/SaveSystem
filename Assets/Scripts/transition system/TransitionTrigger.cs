using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


public class TransitionTrigger : MonoBehaviour
{
    [SerializeField] private string nextSceneName ;



    private void OnTriggerEnter(Collider other)
    {
        GameEvents.current.LoadLevel(nextSceneName);
    }
    
}
