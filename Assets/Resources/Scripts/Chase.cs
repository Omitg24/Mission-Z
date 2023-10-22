using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Chase : MonoBehaviour
{
    public Transform enemy;
    public Transform player;

    public bool isChasing = false;

    public int moveSpeed = 5;

    public string nextScene = "GameOver";

    public bool playerInRadius = false;

    private NavMeshAgent navMeshAgent;

    public AudioSource audio;

    public AudioSource[] sounds;
    public float minTime = 20f;
    public float maxTime = 60f;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (isChasing)
        {
            ChasePlayer();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRadius = isChasing = true;
            InvokeRepeating("ZombieSound", 3f, Random.Range(minTime, maxTime));
            ChasePlayer();
        }
    }

    public void ZombieSound()
    {
        AudioSource randomSound = sounds[Random.Range(0, sounds.Length)];
        randomSound.Play();
    }

    public void ChasePlayer()
    {
        enemy.LookAt(player.position);
        enemy.GetComponent<Animator>().Play("Walk");
        enemy.position += enemy.forward * moveSpeed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("You've been killed by a zombie");
            if (audio != null)
            {
                audio.Play();
            }
            SceneManager.LoadScene(nextScene);
        }
    }

}
