using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Gun : MonoBehaviour
{
    public enum State
    {
        Ready,
        Empty,
        EmptyShoot,
        Reloading
    }

    public State state;
    private Shoot shoot;

    public Transform fireTransform;
    public ParticleSystem muzzlerFlashEffect;
    public ParticleSystem shellEjectEffect;

    private AudioSource gunAudioPlayer;
    public AudioClip[] GunClip;

    public Animator Ani;
    public GameObject cam;

    private UIManager UIM;
    private Destructible destructible;

    public int ammoRemain = 100;
    public int magCapacity = 25;
    public int magAmmo;

    public float timeBetFire = 0.12f;
    public float reloadTime = 1.8f;
    private float lastFireTime;

    private void Awake()
    {
        UIM = GameObject.Find("Canvas").GetComponent<UIManager>();
        Ani = GetComponent<Animator>();
        gunAudioPlayer = GetComponent<AudioSource>(); 
    }

    private void OnEnable()
    {
        magAmmo = magCapacity;
        state = State.Ready;
        lastFireTime = 0;
    }

    public void Fire()
    {
        if(state == State.Ready && Time.time >= lastFireTime + timeBetFire)
        {
            lastFireTime = Time.time;
            shot();
        }

        if(state == State.Empty)
        {
            gunAudioPlayer.clip = GunClip[2];
            gunAudioPlayer.Play();
        }
    }


    public void shot()
    {
        Ani.SetBool("Fire", true);

        RaycastHit hit; //부딪힌 대상의 정보
        Vector3 hitPosition = Vector3.zero;

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit))
        {
            if (hit.transform.tag == "ceramicware")
            {
                destructible = hit.transform.gameObject.GetComponent<Destructible>();
                destructible.Broken();
                UIM.UpdateScoreText(20);
            }
        }       

        magAmmo--;

        StartCoroutine(ShotEffect(hitPosition));

        if (magAmmo <= 0)
        {
            state = Gun.State.Empty;
        }
    }

    public void Idle()
    {
        Ani.SetBool("Fire", false);
    }

    private IEnumerator ShotEffect(Vector3 hitPosition)
    {
        muzzlerFlashEffect.Play();
        shellEjectEffect.Play();

        gunAudioPlayer.clip = GunClip[0];
        gunAudioPlayer.Play();


        yield return new WaitForSeconds(0.03f);

    }

    public void Reload()
    {
        if (state == State.Reloading || ammoRemain <= 0 || magAmmo >= magCapacity)
        {
            return;
        }

        StartCoroutine(ReloadRoutine());
        Ani.SetTrigger("Reload");
    }

    private IEnumerator ReloadRoutine()
    {
        state = State.Reloading;
        gunAudioPlayer.clip = GunClip[1];
        gunAudioPlayer.Play();

        yield return new WaitForSeconds(reloadTime);

        int ammoToFill = magCapacity - magAmmo;

        if(ammoRemain < ammoToFill)
        {
            ammoToFill = ammoRemain;
        }

        magAmmo += ammoToFill;
        ammoRemain -= ammoToFill;

        state = State.Ready;
    }

}
