using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update

    public Camera fpsCam;

    public float range = 100f;
    public float damage = 10f;
    public float impactForce = 200f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Shoot();
            Debug.Log("Fire");
        }
    }

    void Shoot(){
        RaycastHit hit;

        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)){

            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();

            if (target != null){
                target.TakeDamage(damage);
            }
        }
    }
}
