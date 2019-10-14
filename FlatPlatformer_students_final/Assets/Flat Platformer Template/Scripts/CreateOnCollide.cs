/* By: Ryan Scheppler
 * Date: 10/9/19
 * Description: Add to objects meant to create things when they collide
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateOnCollide : MonoBehaviour
{
    public GameObject ObjectToMake;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(ObjectToMake, transform.position, transform.rotation);
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
