using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinWall : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
