using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class AK_CowAI : MonoBehaviour
{
    public int shootingQuantity;
    public bool turretMode;
    AIPath cowPath;

    public GameObject projectile;

    public Transform[] shootingPoints;

    private void Start()
    {
        cowPath = GetComponent<AIPath>();
        turretMode = false;
    }

    private void Update()
    {
        if (turretMode)
        {
            cowPath.canMove = false;

            Vector3 diff = GameObject.FindGameObjectWithTag("Player").transform.position - gameObject.transform.position;
            diff.Normalize();
            float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);

        }
        else
        {
            cowPath.canMove = true;
        }
    }

    public void TurretActivated()
    {
        StartCoroutine(TurretCoroutine());
    }

    IEnumerator TurretCoroutine()
    {
        turretMode = true;

        for(int i = 0; i < shootingQuantity; i++)
        {
            for(int j = 0; j < shootingPoints.Length; j++)
            {
                Instantiate(projectile, shootingPoints[j].position, shootingPoints[j].rotation);
            }
            yield return new WaitForSeconds(0.2f);
        }

        yield return new WaitForSeconds(2f);

        turretMode = false;

        yield return null;
    }
}
