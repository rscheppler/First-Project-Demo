/* By: Ryan Scheppler
 * Date: 10/9/19
 * Description: Deprecated: was originally to have enemies get destroyed
 */

using UnityEngine;
using UnityEditor;

public class Enemy : MonoBehaviour
{
    public int Health = 20;

    private void Update()
    {
        if(Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}