using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    private Vector3 Min;
    private Vector3 Max;
    private float xAxis;
    private float yAxis;
    private float zAxis;
    private Vector3 randomPosition;
    public GameObject enemy;
    public GameObject asteroid;

    private void Start()
    {
        SetRanges();
        InstantiateRandomObjects();
    }

    private void Update()
    {
    }

    //Here put the ranges where your object will appear, or put it in the inspector.
    private void SetRanges()
    {
        Min = new Vector3(-100, -100, -100); //Random value.
        Max = new Vector3(100, 100, 100); //Another ramdon value, just for the example.
    }

    private void InstantiateRandomObjects()
    {
        for (int i = 0; i < 100; i++)
        {
            xAxis = Random.Range(Min.x, Max.x);
            yAxis = Random.Range(Min.y, Max.y);
            zAxis = Random.Range(Min.z, Max.z);
            randomPosition = new Vector3(xAxis, yAxis, zAxis);
            Instantiate(enemy, randomPosition, Quaternion.identity);

            xAxis = Random.Range(Min.x, Max.x);
            yAxis = Random.Range(Min.y, Max.y);
            zAxis = Random.Range(Min.z, Max.z);
            randomPosition = new Vector3(xAxis, yAxis, zAxis);
            Instantiate(asteroid, randomPosition, transform.rotation);
        }
    }
}
