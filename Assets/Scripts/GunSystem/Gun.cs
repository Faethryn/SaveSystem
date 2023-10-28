using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    
    [SerializeField] protected Transform nozzle;
    [SerializeField] private GameObject GunModel;
    [SerializeField]
    private enum AmmoTypes
    { 
        Physical, Energy, Elemental
    };

    


    public void DeviatingRaycast(Transform beginning, Transform target , float maxDeviationAngle)
    {

        Vector3 adjustedTarget = Vector3.Normalize(target.position - beginning.position);
        Quaternion deviation = Quaternion.Euler(Random.Range(-maxDeviationAngle, maxDeviationAngle), Random.Range(-maxDeviationAngle, maxDeviationAngle), 0);
        //Vector3 deviation = ((Random.insideUnitSphere /  (2 * Mathf.PI)) * maxDeviationAngle);
        adjustedTarget = deviation * adjustedTarget;
        adjustedTarget += beginning.position;
        
        RaycastHit hit;
        Physics.Raycast(beginning.position, adjustedTarget, out hit, 40);
        Debug.DrawLine(beginning.position, adjustedTarget, Color.red, 5);
            
        

    }


    public void ProjectileSpawning(GameObject spawnedObject, Transform forward)
    {
        Instantiate(spawnedObject, transform.position, transform.rotation);

    }

   

    public virtual void Fire()
    {

    }
    







    





}
