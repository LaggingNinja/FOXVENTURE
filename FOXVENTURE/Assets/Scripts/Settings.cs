using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public GameObject player;
    public GameObject SettingsPanel;
    public GameObject SettingsBtn;
    public GameObject ConfirmPanel;
    public GameObject InfoPanel;
    public GameObject AudioPanel;


    public void OnClick()
    {
        SettingsPanel.SetActive(true);
        SettingsBtn.SetActive(false);
        player.SetActive(false);
    }
    public void OnClickBack()
    {
        SettingsPanel.SetActive(false);
        SettingsBtn.SetActive(true);
        player.SetActive(true);
    }

    public void OnClickRestart()
    {
        SettingsPanel.SetActive(false);
        SettingsBtn.SetActive(true);
        FindObjectOfType<GameManager>().RestartGame();
    }

    public void OnClickHome()
    {
        SettingsPanel.SetActive(false);
        ConfirmPanel.SetActive(true);
    }

    public void OnClickPanel()
    {
        SettingsPanel.SetActive(false);
        InfoPanel.SetActive(true);
    }

    public void OnClickPanelBack()
    {
        SettingsPanel.SetActive(false);
        SettingsBtn.SetActive(true);
        InfoPanel.SetActive(false);
        player.SetActive(true);
    }

    public void OnClickAudioPanel()
    {
        SettingsPanel.SetActive(false);
        AudioPanel.SetActive(true);
    }
    public void OnClickAudioPanelBack()
    {
        SettingsPanel.SetActive(true);
        AudioPanel.SetActive(false);
    }
}
