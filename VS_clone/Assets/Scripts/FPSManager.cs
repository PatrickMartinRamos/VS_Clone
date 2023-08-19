using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSManager : MonoBehaviour
{
    public int FPS;

    public void Awake()
    {
        Application.targetFrameRate = FPS;
    }
}
