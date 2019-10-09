using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hacker : MonoBehaviour
{
    //int level;
    enum Screen { MainMenu,PassWord, Win }
    Screen currentScreen = Screen.MainMenu;

    // Use this for initialization
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("Press 1 for Harvard University: ");
        Terminal.WriteLine("Press 2 for World Bank: ");
        Terminal.WriteLine("Press 3 for White House: ");
        Terminal.WriteLine("So, Whats your interest? ");
    }

    void OnUserInput(string input)
    {
        if (input == "1")
        {
            Terminal.WriteLine("You have picked, Harvard University");
            StartGame();
        }
        else if (input == "2")
        {
            Terminal.WriteLine("You have picked, World Bank");
            StartGame();
        }
        else if (input == "3")
        {
            Terminal.WriteLine("You have picked, White House");
            StartGame();
        }
        else if (input == "menu" || input == "MENU")
        {
            ShowMainMenu();
        }
        else {
            Terminal.WriteLine("PRESS A NUMBER NOT WRITE...");
            Terminal.WriteLine("Write MENU to Refresh the Page");
        }
    }

    public void StartGame()
    {
        currentScreen = Screen.PassWord;
        Terminal.WriteLine("Please Enter your PassWord: ");
    }
}
