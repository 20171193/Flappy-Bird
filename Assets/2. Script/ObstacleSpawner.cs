using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{ 
    private Coroutine spawnRoutine;

    [SerializeField]
    GameObject pipePrefab;

   
    [SerializeField]
    RectTransform spawnPos;

    private void OnEnable()
    {
        spawnRoutine = StartCoroutine(SpawnRoutine());
    }
    private void OnDisable()
    {
        StopCoroutine(spawnRoutine);
    }

    IEnumerator SpawnRoutine()
    {
        while(true)
        {
            yield return new WaitForSeconds(GameManger.Ballance.ObstacleSpawnTime);
            Instantiate(pipePrefab, spawnPos);
        }
    }
}
