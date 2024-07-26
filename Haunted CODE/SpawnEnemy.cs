using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class SpawnEnemy : MonoBehaviour
{
   
    public GameObject enemy;
    public GameObject spawnPoint;
 
    public int xPos;
    public int yPos;
 
    public int enemyCount = 20;
 
    // Update is called once per frame
    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        enemyCount = enemies.Length;
 
        if(enemies.Length <= 20){
            xPos = Random.Range(1,50);
            yPos = Random.Range(10,20);
 
            Instantiate(enemy, new Vector3(spawnPoint.transform.position.x + xPos, 0, spawnPoint.transform.position.z + yPos), Quaternion.identity);
        }
    }
}