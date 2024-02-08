using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ObstaclePattern
{
    Up,
    Donw,
    UpDown
}

public class ObstacleSpawner : MonoBehaviour
{
    public void SpawnObstacle(ObstaclePattern otcPattern)
    {
        switch(otcPattern)
        {
            case ObstaclePattern.Up:
                break;
            case ObstaclePattern.Donw:
                break;
            case ObstaclePattern.UpDown:
                break;
        }
    }
}
