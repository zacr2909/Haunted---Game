using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // Start is called before the first frame update
   public static EnemyManager instance;

   void Awake(){

        instance = this;
   }

   public GameObject spawnPoint;
}
