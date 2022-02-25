using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreate : MonoBehaviour
{
    [SerializeField]
    private GameObject busEnemy;

    private float enemyRespawnCounter = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(busEnemy, new Vector3(-7, 4.768f, 180),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        enemyRespawnCounter += Time.deltaTime;
    }
}
