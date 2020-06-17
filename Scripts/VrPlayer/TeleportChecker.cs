using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportChecker : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private DrawGrid drawGrid;
    private Vector3 lastPosition;

    void Start()
    {
        lastPosition = playerTransform.position;
    }

    //TODO: only check me after teleporting
    void Update()
    {
        if (lastPosition != playerTransform.position)
        {
            drawGrid.DrawCells();
        }
    }
}
