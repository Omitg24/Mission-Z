using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveChase : MonoBehaviour
{

    public Animator anim;
    
    void OnTriggerEnter(Collider other)
    {
        anim.SetFloat("vertical", 0);
        anim.SetFloat("horizontal", 0);
        if (other.CompareTag("Player"))
        {
            Debug.Log("Destroying all zombies");
            GameObject[] zombies = GameObject.FindGameObjectsWithTag("Zombie");
            foreach (GameObject zombie in zombies)
            {
                Chase chase = zombie.GetComponent<Chase>();
                Destroy(chase);
            }
        }
    }
}
