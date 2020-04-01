using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    
        
    void Start()
    {
        
        ShowMainMenu();
    }
       
                     
    void ShowMainMenu ()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Qual o seu nível Hacker?");
        Terminal.WriteLine("Aperte 1 para easy!");
        Terminal.WriteLine("Aperte 2 para normal!");
        Terminal.WriteLine("Aperte 3 para Hard!");
        Terminal.WriteLine("");
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
            Terminal.WriteLine("você escolheu o level 1");
        }

        else if (input == "2")
        {
            Terminal.WriteLine("você escolheu o level 2");
        }
        else if (input == "3")
        {
            Terminal.WriteLine("você escolheu o level 3");
        }
        else
        {
            Terminal.WriteLine("Escolha novamente karai");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
