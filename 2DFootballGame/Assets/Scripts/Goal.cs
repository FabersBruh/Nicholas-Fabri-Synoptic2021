﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        StartCoroutine(LoadLevelDelay());
        Destroy(collider.gameObject);
    }

    IEnumerator LoadLevelDelay()
    {
        
        if (Scores.goalnum == 20)
        {
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene("Winner");
        }
        else
        {
            Scores.goalnum += 1;
        }
    }
}
