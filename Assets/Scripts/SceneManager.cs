using System;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    [SerializeField] private Animator _smallHouseAnimator;

    private void Start()
    {
        OpenDoor();
    }

    private void OpenDoor()
    {
        _smallHouseAnimator.SetTrigger("OpenDoor");
    }
}
