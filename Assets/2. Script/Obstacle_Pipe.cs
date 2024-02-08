using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Obstacle_Pipe : MonoBehaviour
{
    [SerializeField]
    RectTransform rectTransform;

    private void Start()
    {
        int rand = Random.Range(-400, 700);
        rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, rand);
        Destroy(gameObject, GameManger.Ballance.GameSpeed * 4f);
    }
    private void Update()
    {
        rectTransform.Translate(Vector3.left * GameManger.Ballance.GameSpeed * 2f * Time.deltaTime);
    }
}
