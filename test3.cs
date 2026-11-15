using System.IO;
using UnityEngine;
using UnityEngine.Rendering;

public class test3 : MonoBehaviour
{
    public int health = 5;
    public int level = 1;
    public float speed = 1.2f;
    public float rotationSpeed = 90f;

    void Start()
    {
        health += level;
        print("Жизней: " + health);
    }
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;

        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
