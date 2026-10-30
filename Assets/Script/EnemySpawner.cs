using System.Threading;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnCooldown = 2;
    public GameObject enemyObjects;
    public float minPosition;
    public float maxPosition;
    public float timer;

    public float minSpeed;
    public float maxSpeed;

    public float moveSpeed; 

    //// Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{
    //    timer = 0;
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    timer += Time.deltaTime;
    //    if(timer >= spawnCooldown) 
    //    {
    //        timer = 0;
    //       // Debug.Log("spawn enemy");
    //        Object.Instantiate(enemyObjects, transform.position, transform.rotation);
    //     }
    //}
    //private void SpawnEnemy()
    //{
    //    Vector3 randomPosition = transform.position;
    //    randomPosition.y = Random.Range(minPosition, maxPosition);
    //    Object.Instantiate(enemyObjects, transform.position, transform.rotation);

        
    //    int = Random.Range(0, enemyObjects.Length);
    //    GameObject enemyPrefab = enemyObjects[targetEnemyIndex];
        
    //    GameObject e = enemyObjects[Random.Range(0, enemyObjects.Length)];

    //    float randomSpeed = Random.Range(minSpeed, maxSpeed);
    //EnemyMovement enemyMovement = enemy.GetComponent<EnemyMovement>();
    //    enemyMovement.moveSpeed = randomSpeed;
    //}


}
