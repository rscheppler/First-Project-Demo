/* By: Ryan Scheppler
 * Date: 10/9/19
 * Description: Deprecated: was originally to cause damage to enemies but did it directly to thier scripts.
 */

using UnityEngine;
using System.Collections;

public class Sword : MonoBehaviour
{
    int DamageAmount = 10;

    bool DestroyOnCollide = false;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.Health -= DamageAmount;
            
        }
        if (DestroyOnCollide)
        {
           
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.Health -= DamageAmount;

        }
        if (DestroyOnCollide)
        {

            Destroy(gameObject);
        }
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
