using UnityEngine;
using UnityEngine.UI; 
using System;

[RequireComponent(typeof(Text))] 
public class Distancemeter : MonoBehaviour
{
    private Vector3 startPosition;
    private Text distanceText; 
    public Transform target; 

    void Awake()
    {
        distanceText = GetComponent<Text>();

        startPosition = new Vector3(target.position.x, 0, target.position.z);
    }

    void Update()
    {

        Vector3 currentPosition = new Vector3(target.position.x, 0, target.position.z);
        float distance = Vector3.Distance(startPosition, currentPosition);

        distance = MathF.Round(distance, 2);

        distanceText.text = $"Distance: {distance} ì";
    }
}

