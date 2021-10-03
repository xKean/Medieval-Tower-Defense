using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] bool isPlacable;
    public bool IsPlacable { get { return isPlacable; } }
    [SerializeField] Tower towerPrefab;

    void OnMouseDown()
    {
        if (isPlacable)
        {
            bool isPlaced = towerPrefab.CreateTower(towerPrefab, transform.position);
            isPlacable = !isPlaced;
        }
    }
}
