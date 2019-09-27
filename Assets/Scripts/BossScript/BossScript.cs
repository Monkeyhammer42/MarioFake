using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{


    public GameObject stone;
    public Transform attackInstanciate;
    private Animator anim;
    private string coroutine_Name = "StartAttack";
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Start()
    {
        
    }
    IEnumerator StartAttack()
    {
        yield return new WaitForSeconds(Random.Range(2f, 5f));
        anim.Play("BossAttack");
    }



































}
