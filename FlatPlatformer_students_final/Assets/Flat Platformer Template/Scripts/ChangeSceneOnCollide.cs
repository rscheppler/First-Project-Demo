﻿/* By: Ryan Scheppler
* Date: 10/9/19
* Description: Add to object to cause a scene change when the player touches it.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class ChangeSceneOnCollide : MonoBehaviour
{
    public string NextScene = "EndScene";


    public UnityEvent OnHit;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            //run any extra effects
            OnHit.Invoke();
            SceneManager.LoadScene(NextScene);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
