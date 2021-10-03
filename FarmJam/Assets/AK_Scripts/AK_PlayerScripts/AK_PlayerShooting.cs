using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_PlayerShooting : MonoBehaviour
{
    public GameObject pellet;
    public Transform[] shootingPoint;

    public float shootingCooldown;
    public float spreadAngle;

    float cooldown;

    public AK_ShotgunAnim gunAnim;
    AK_PlayerSound playerSound;


    private void Start()
    {
        playerSound = GetComponentInParent<AK_PlayerSound>();
        cooldown = shootingCooldown;
        shootingCooldown = 0;
    }

    private void Update()
    {
        if(shootingCooldown > 0)
        {
            shootingCooldown -= Time.deltaTime;
            
        }

        if(Input.GetButtonDown("Fire1") && shootingCooldown <= 0)
        {
            Shootgun();
        }
    }


    public void Shootgun()
    {
        StartCoroutine(ShootgunDoubleShot());
    }

    IEnumerator ShootgunDoubleShot()
    {
        playerSound.PlaySoundOS(playerSound.SHOOTING);

        gunAnim.ChangeAnimationState(gunAnim.GUN_SHOOTING);

        shootingCooldown = cooldown;

        for (int i = 0; i < shootingPoint.Length; i++)
            Instantiate(pellet, shootingPoint[i].position, shootingPoint[i].rotation * Quaternion.Euler(0.0f, 0.0f, Random.Range(-spreadAngle, spreadAngle)));

        yield return new WaitForSeconds(0.1f);

        for (int i = 0; i < shootingPoint.Length; i++)
            Instantiate(pellet, shootingPoint[i].position, shootingPoint[i].rotation * Quaternion.Euler(0.0f, 0.0f, Random.Range(-spreadAngle, spreadAngle)));

        gunAnim.ChangeAnimationState(gunAnim.GUN_IDLE);
        yield return null;
    }
}


    
