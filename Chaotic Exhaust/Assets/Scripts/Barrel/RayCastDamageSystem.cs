using System.Collections;
using UnityEngine;

public class RayCastDamageSystem : IsShootable
{
    //public int hp = 1;
    
    private AudioSource _hitShot;
    private LifeBehaviour _hpComponent;
    private Renderer _myRenderer;
    private RoomTrigger _roomTrigger;

    public delegate void dieMetod();
    dieMetod _damageMetod;

    [SerializeField]
    private Color _hurtColor = Color.red;
    private Color _normalColor;

    public RayCastDamageSystem(AudioSource hitShot, Renderer myRenderer, int hp, dieMetod damageMetod)
    {
        _hitShot = hitShot;
        _myRenderer = myRenderer;

        _damageMetod = damageMetod;

        _normalColor = myRenderer.material.color;

        _hpComponent = new LifeBehaviour(DamageFeedback, _hitShot, hp);
    }

    private void Awake()
    {
        //_hitShot = GetComponent<AudioSource>();
        //_myRenderer = GetComponent<Renderer>();
        //_roomTrigger = FindObjectOfType<RoomTrigger>();
    }

    public int ReturnHP()
    {
        return _hpComponent.hp;
    }

    public void Damage(int dmg)
    {
        _hpComponent.takeDamage(dmg);

        if (_hpComponent.hp <= 0)
        {
            _damageMetod();
        }
    }

    public void DamageFeedback()
    {
        //StartCoroutine(DamagedFeedback());
    }

    public IEnumerator DamagedFeedback()
    {

        _myRenderer.material.color = _hurtColor;

        yield return new WaitForSeconds(.5f);

        _myRenderer.material.color = _normalColor;

        //if (_hpComponent.hp <= 0)
        //{
        //    Die();
        //}

    }

    //public void Die()
    //{
    //    if (gameObject.layer == LayerMask.NameToLayer("Enemy"))
    //    {
    //        _roomTrigger.OnEnemyKilled();
    //    }
    //    Destroy(gameObject);
    //}
}
