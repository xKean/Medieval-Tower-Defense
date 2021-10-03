using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] bool isPlacable;
    public bool IsPlacable { get { return isPlacable; } }
    [SerializeField] GameObject towerPrefab;

    void OnMouseDown()
    {
        if (isPlacable)
        {
            Instantiate(towerPrefab, transform.position, Quaternion.identity);
            isPlacable = false;
        }
    }
}
