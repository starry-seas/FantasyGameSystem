using System.Runtime.CompilerServices;

public class MainMenu
{
    public string[] MenuItems {get; set;}

    public MainMenu()
    {
        MenuItems = new string[]
        {
            "Grimoire",
            "Cast Spell",
            "My Stats",
            "Leave Menu",
            "Exit Game"
        };

    }

    public void InteractiveMenue()
    {
        ConsoleKeyInfo key;
        bool isSelected = false;
        (int left, int top) = Console.GetCursorPosition();
        var selectedMenu = 0;
        string selectionColour = "\u001b[32m";

        while (!isSelected)
        {
            Console.SetCursorPosition(left, top);

            for (int i = 0; i <MenuItems.Length; i++)
            {
                Console.WriteLine($"{(selectedMenu == i ? selectionColour : "  ")}{MenuItems[i]}\u001b[0m"); 
            }

            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.DownArrow:
                    selectedMenu = selectedMenu == MenuItems.Length -1 ? 0 : selectedMenu + 1; 
                    break;

                case ConsoleKey.UpArrow:
                    selectedMenu = selectedMenu == 0 ? MenuItems.Length - 1 : selectedMenu - 1;
                    break;

                case ConsoleKey.Enter:
                    isSelected = true;
                    break;
            }

        }
    }

    public void ShowGrimoire()
    {
        //method to display player Grimoire when selected
    }

    public void ShowStats()
    {
        //method to display player stats when selected
    }

    public void CastSpell()
    {
        //method for player to cast spell
    }

    public void LeaveMenu()
    {
        
    }

    public void ExitGame()
    {
        
    }
}