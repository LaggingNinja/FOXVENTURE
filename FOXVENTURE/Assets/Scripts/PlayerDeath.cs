
using UnityEngine;
using UnityEngine.Events;

public class PlayerDeath : MonoBehaviour
{
    public PlayerMovement movement;
    public Animator animator;
    [Header("Events")]
    [Space]
    public UnityEvent Blank;

    [System.Serializable]
    public class BoolEvent : UnityEvent<bool> { }
    public BoolEvent OnHitEvent;

    public GameObject DeathText;

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.transform.tag == "Enemy")
        {
            //Debug.Log(" Player hit " + collision.transform.name);
            movement.enabled = false;
            DeathText.SetActive(true);
            OnHitEvent.Invoke(true);
            FindObjectOfType<GameManager>().EndGame();

        }
    }
    public void OnHit(bool Hit)
    {
        animator.SetBool("Hit", Hit);
    }
}
