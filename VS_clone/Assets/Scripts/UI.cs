using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public void testtouch()
    {
       Debug.Log("it works");
        SceneManager.LoadScene(1);
    }
}
