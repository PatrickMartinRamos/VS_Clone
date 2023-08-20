using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class playerCombat : MonoBehaviour
{
    private Player_input input = null;
    public Transform attackPoint;

    public GameObject bulletPref;


    private void Awake()
    {
        input = new Player_input();
    }

    private void OnEnable()
    {
        input.Enable();
        input.Player.attack.performed += onAttackPerformed;
        input.Player.attack.canceled += onAttackCancel;
    }

    private void OnDisable()
    {
        input.Disable();
        input.Player.attack.performed -= onAttackPerformed;
        input.Player.attack.canceled -= onAttackCancel;
    }

    private void onAttackPerformed(InputAction.CallbackContext value)
    {
        Debug.Log("work");
        Instantiate(bulletPref, attackPoint.position, Quaternion.identity);
    }

    private void onAttackCancel(InputAction.CallbackContext value)
    {

    }
}
