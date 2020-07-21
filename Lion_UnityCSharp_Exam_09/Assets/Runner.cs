using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Runner : MonoBehaviour
{
    public float speed = 25;
    public float turn = 5;
    private Vector3 angle;
    private Rigidbody rig;
    private Animator ani;
    private AudioSource aud;
    public Text tex;

    private void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        rig.AddForce(transform.forward * speed * Mathf.Abs(x));
        rig.AddForce(transform.forward * speed * Mathf.Abs(y));

        ani.SetBool("run", Mathf.Abs(x) > 0 || Mathf.Abs(y) > 0);

        if (x == 1) angle = new Vector3(0, 90, 0);
        if (x == -1) angle = new Vector3(0, 270, 0);
        if (y == 1) angle = new Vector3(0, 0, 0);
        if (y == -1) angle = new Vector3(0, 180, 0);

        transform.eulerAngles = angle;
    }

    private void Start()
    {
        rig = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();
    }

    private void Update()
    {
        Move();
    }

    public AudioClip end;
    public GameObject endT;

    private void HitTarget(GameObject tar)
    {
        if (tar.tag == "tar")
        {
            aud.PlayOneShot(end, 1);
            endT.SetActive(true);
        }
    }
}
