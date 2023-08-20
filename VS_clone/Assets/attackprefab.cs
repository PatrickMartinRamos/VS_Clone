using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackprefab : MonoBehaviour
{
     public float bulletSpeed = 10f; // Adjust the speed as needed

    private void Update()
    {
        // Move the bullet forward based on its speed
        transform.Translate(Vector2.right * bulletSpeed * Time.deltaTime);
    }
}
