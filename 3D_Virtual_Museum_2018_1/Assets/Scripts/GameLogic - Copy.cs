using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{

    public GameObject MainMenuPanel;
    public GameObject TutorialPanel;
    public GameObject MapPanel;
    public GameObject aboutPanel;
    public GameObject QuitPanel;
    public GameObject VRBasics;
    public GameObject Movement;
    public GameObject Interaction;



    // Use this for initialization
    void Start()
    {
        MainMenuPanel.SetActive(true);
        MapPanel.SetActive(false);
        aboutPanel.SetActive(false);
        QuitPanel.SetActive(false);
        VRBasics.SetActive(false);
        Movement.SetActive(false);
        Interaction.SetActive(false);

    }

    //public void LoadScene(string scenename){
    //SceneManager.LoadScene(scenename);
    //}

    public void MapClicked()
    {
        TutorialPanel.SetActive(false);
        MapPanel.SetActive(true);
        aboutPanel.SetActive(false);
        QuitPanel.SetActive(false);
        VRBasics.SetActive(false);
        Movement.SetActive(false);
        Interaction.SetActive(false);
    }

    public void TutorialClicked()
    {
        TutorialPanel.SetActive(true);
        MapPanel.SetActive(false);
        aboutPanel.SetActive(false);
        QuitPanel.SetActive(false);
        VRBasics.SetActive(false);
        Movement.SetActive(false);
        Interaction.SetActive(false);
    }

    public void AboutClicked()
    {
        TutorialPanel.SetActive(false);
        aboutPanel.SetActive(true);
        MapPanel.SetActive(false);
        QuitPanel.SetActive(false);
        VRBasics.SetActive(false);
        Movement.SetActive(false);
        Interaction.SetActive(false);
    }

    public void QuitClicked()
    {
        TutorialPanel.SetActive(false);
        QuitPanel.SetActive(true);
        aboutPanel.SetActive(false);
        MapPanel.SetActive(false);
        VRBasics.SetActive(false);
        Movement.SetActive(false);
        Interaction.SetActive(false);
        MainMenuPanel.SetActive(false);
    }

    public void NoClicked()
    {
        TutorialPanel.SetActive(false);
        MapPanel.SetActive(false);
        aboutPanel.SetActive(false);
        QuitPanel.SetActive(false);
        VRBasics.SetActive(false);
        Movement.SetActive(false);
        Interaction.SetActive(false);
        MainMenuPanel.SetActive(true);
    }

    public void YesGameClick()
    {
        Application.Quit();
    }

    public void NoVRBasicsClicked()
    {
        TutorialPanel.SetActive(true);
        MapPanel.SetActive(false);
        aboutPanel.SetActive(false);
        QuitPanel.SetActive(false);
        VRBasics.SetActive(true);
        Movement.SetActive(false);
        Interaction.SetActive(false);
    }

    public void MovementClicked()
    {
        TutorialPanel.SetActive(true);
        MapPanel.SetActive(false);
        aboutPanel.SetActive(false);
        QuitPanel.SetActive(false);
        VRBasics.SetActive(false);
        Movement.SetActive(true);
        Interaction.SetActive(false);
    }

    public void InteractionClicked()
    {
        TutorialPanel.SetActive(true);
        MapPanel.SetActive(false);
        aboutPanel.SetActive(false);
        QuitPanel.SetActive(false);
        VRBasics.SetActive(false);
        Movement.SetActive(false);
        Interaction.SetActive(true);
    }


    public void BackClicked()
    {
            MainMenuPanel.SetActive(true);
            TutorialPanel.SetActive(false);
            MapPanel.SetActive(false);
            aboutPanel.SetActive(false);
            QuitPanel.SetActive(false);
            VRBasics.SetActive(false);
            Movement.SetActive(false);
            Interaction.SetActive(false);


    }
}
