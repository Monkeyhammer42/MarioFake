﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private Text coinTextScore;
    private AudioSource audioManager;
    public int scoreCount;
    void Awake()
    {
        audioManager = GetComponent<AudioSource>();
    }
    void Start()
    {
        coinTextScore = GameObject.Find("CoinText").GetComponent<Text>();

    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == MyTags.COIN_TAG)
        {
            target.gameObject.SetActive(false);
            IncrementScore();
        }
    }

    public void IncrementScore()
    {
        scoreCount++;
        coinTextScore.text = "x" + scoreCount.ToString();
        audioManager.Play();
    }

}
