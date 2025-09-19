using System;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    [SerializeField] private float animationAwaitTime = 25f;
    [SerializeField] private Animator _smallHouseAnimator;

    private void Start()
    {
        Invoke(nameof(OpenDoor), animationAwaitTime);
    }

    private void OpenDoor()
    {
        
        _smallHouseAnimator.SetTrigger("OpenDoor");
    }
}
