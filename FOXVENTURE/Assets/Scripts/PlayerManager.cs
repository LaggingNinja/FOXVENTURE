using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class PlayerManager : MonoBehaviour
{
    private float gem = 0;
    private float cherry = 0;

    public TextMeshProUGUI textGems;
    public TextMeshProUGUI textCherry;
    public GameObject SignText;
    public GameObject SignText2;
    public GameObject Special;
    public GameObject Special1;
    public Animator animator;
    public Animator animator2;
    public Animator animator3;
    public Animator animator4;
    public Animator animator5;
    public GameObject End;



    private void OnTriggerEnter2D(Collider2D other)
    {

            if (other.transform.tag == "Gem")
            {
                Destroy(other.gameObject);
                gem++;
                textGems.text = gem.ToString();
                FindObjectOfType<AudioManager>().Play("Collect");
                Debug.Log("Collected");
            }

            if (other.transform.tag == "Cherry")
            {
                Destroy(other.gameObject);
                cherry++;
                textCherry.text = cherry.ToString();
                FindObjectOfType<AudioManager>().Play("Eat");
            }
        
        if (other.transform.tag == "HighJumpPower")
        {
            FindObjectOfType<AudioManager>().Play("Skill");
            Destroy(other.gameObject);
            animator.SetTrigger("HighJump");
        }
        if (other.transform.tag == "RunItBack")
        {
            FindObjectOfType<AudioManager>().Play("Skill");
            Destroy(other.gameObject);
            animator2.SetTrigger("Check");
        }
        if (other.transform.tag == "Wings")
        {
            FindObjectOfType<AudioManager>().Play("Skill");
            Destroy(other.gameObject);
            animator3.SetTrigger("Wings");
        }
        if (other.transform.tag == "Speed")
        {
            FindObjectOfType<AudioManager>().Play("Skill");
            Destroy(other.gameObject);
            animator4.SetTrigger("Wings");
        }
        if (other.transform.name == "door")
        {
            Destroy(other.gameObject);
            End.SetActive(true);
            //FindObjectOfType<Confirmation>().StopPlayer();
            animator5.SetTrigger("End");
            FindObjectOfType<AudioManager>().Stop("Theme");
            FindObjectOfType<AudioManager>().Play("JojoSong");
            FindObjectOfType<Checkpoint>().SetInitial();
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.name == "sign1")
        {
            SignText.SetActive(true);
        }
        if (collision.transform.name == "sign2")
        {
            SignText2.SetActive(true);
        }
        if (collision.transform.name == "sign3")
        {
            Special.SetActive(true);
            Special1.SetActive(true);
        }
 /*       if (collision.transform.name == "door")
        {
            End.SetActive(true);
            //FindObjectOfType<Confirmation>().StopPlayer();
            animator5.SetTrigger("End");
            FindObjectOfType<AudioManager>().Stop("Theme");
            FindObjectOfType<AudioManager>().Play("JojoSong");
            FindObjectOfType<Checkpoint>().SetInitial();
        }*/
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.name == "sign1")
        {
            SignText.SetActive(false);
        }
        if (collision.transform.name == "sign2")
        {
            SignText2.SetActive(false);
        }
        if (collision.transform.name == "sign3")
        {
            Special.SetActive(false);
            Special1.SetActive(false);
        }
    }




}
