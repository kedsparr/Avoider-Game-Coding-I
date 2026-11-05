using UnityEngine;
using UnityEngine.InputSystem;
public class TreatBehavior : MonoBehaviour
{
    public GameObject[] enemyObjects;
    public float spawnCooldown = 2;

    public float minPosition;
    public float maxPosition;

    public float minEnemySpeed;
    public float maxEnemySpeed;

    private float timer;

    private void Start()
    {
        timer = 0;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnCooldown)
        {
            timer = 0;
            SpawnTreat();
        }
    }


    private void SpawnTreat()
    {
        // get random position to spawn at
        Vector3 randomPosition = transform.position;
        randomPosition.y = Random.Range(minPosition, maxPosition);

        // get random enemy prefab from list
        int targetTreatIndex = Random.Range(0, enemyObjects.Length);
        GameObject enemyPrefab = enemyObjects[targetTreatIndex];

        // spawn the enemy
        GameObject Treat = Object.Instantiate(enemyPrefab, randomPosition, transform.rotation);

        float randomSpeed = Random.Range(minEnemySpeed, maxEnemySpeed);
        BackMovement enemyMovement = Treat.GetComponent<BackMovement>();
        enemyMovement.moveSpeed = randomSpeed;
    }
}