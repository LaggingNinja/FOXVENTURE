using UnityEngine;

public class Confirmation : MonoBehaviour
{
    public GameObject player;
    public GameObject SettingsPanel;
    public GameObject SettingsBtn;
    public GameObject ConfirmPanel;
    public void OnClickYes()
    {
        FindObjectOfType<GameManager>().Back();
    }
    public void OnClickNo()
    {
        SettingsPanel.SetActive(false);
        SettingsBtn.SetActive(true);
        ConfirmPanel.SetActive(false);
        player.SetActive(true);
    }
    public void StopPlayer()
    {
        player.SetActive(false);
    }
    public void EndGameBack()
    {
        FindObjectOfType<AudioManager>().Stop("JojoSong");
        FindObjectOfType<AudioManager>().Play("Theme");
        FindObjectOfType<GameManager>().Back();
    }
}
