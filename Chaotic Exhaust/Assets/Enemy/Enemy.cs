using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    //Variables Privadas por Referencia
    private RayCastDamageSystem _enemyRay;
    public NavMeshAgent navMeshAgent;
    public Transform[] destinations;
    private EnemyAI _movement;
    public int hp;
    private GameObject _player;
    public int dmg = 1;


    private void Awake()
    {
        _enemyRay = new RayCastDamageSystem(GetComponent<AudioSource>(), GetComponent<Renderer>(), hp, Die);
        _player = FindObjectOfType<PlayerMovement>().gameObject;
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        _movement = new EnemyAI(this, _player);
        _movement.ArtificialStart();
    }

    void Die()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        if ()
        {
            _enemyRay.Damage(dmg);

            Debug.Log(_enemyRay.ReturnHP());
        }
        _movement.ArtificialUpdate();
    }
}
