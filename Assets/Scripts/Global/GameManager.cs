using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public enum EServantClass
{
    Saber,
    Lancer,
    Archer,
    Rider,
    Caster,
    Assassin,
    Berserker
}

public class GameManager : Singletone<GameManager>
{
    public GameObject[] PlayTunButtons;

    private ButtonController buttonController;
    private 

    bool isPlayTun = true;


    // Start is called before the first frame update
    void Start()
    {
        buttonController.OnFightEvent += Fight;
        //buttonController.OnActEvent += Action;
        //buttonController.OnItemEvent += Item;
        //buttonController.OnMercyEvent += Mercy;

        if (isPlayTun)
        {
            ButtonSetActive(true);

        }
    }

    private void ButtonSetActive(bool Active)
    {
        foreach (var button in PlayTunButtons)
        {
            button.SetActive(Active);
        }
    }

    private void Fight()
    {

    }

    private void Action()
    {

    }

    private void Item()
    {

    }

    private void Mercy()
    {

    }
}
