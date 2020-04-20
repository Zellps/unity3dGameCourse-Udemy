using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update

    //Game State
    int level;

    enum Screen = {}

    void Start()
    {

        ShowMainMenu();
    }


    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Qual o seu nível Hacker?");
        Terminal.WriteLine("Aperte 1 para easy!");
        Terminal.WriteLine("Aperte 2 para normal!");
        Terminal.WriteLine("Digite a sua opção");
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }

        else if (input == "1")
        {
            level = 1;
            StartGame();
        }

        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "007")
        {
            Terminal.WriteLine("Por favor escolha um level Mr. Bond!");
        }
        else
        {
            Terminal.WriteLine("Escolha novamente karai");

        }
    }

    void StartGame()
    {
        Terminal.WriteLine("você escolheu o level " + level);
        Terminal.WriteLine("Digite o password: ");
    }

}