using System;

namespace Game
{
    class Program
    {
    static void Main(string[] args) {
    bool playing = true;
    int money = 0;
    int x = 0;
    int y = 0;
    while (playing) {
        Console.WriteLine("Are you ready to start the game? y/n");
        char start = Convert.ToChar(Console.ReadLine());
        if (start == 'y') {
            Console.WriteLine("Welcome to the dungeon! You are in a dark room.");
            while (true) {
                Console.WriteLine("Enter a direction to move (a=left, d=right, w=forward, s=backward): ");
                char input = Convert.ToChar(Console.ReadLine());
                if (input == 'a') {
                    x--;
                } else if (input == 'w') {
                    y++;
                } else if (input == 's') {
                    y--;
                } else if (input == 'd') {
                    x++;
                } else {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                int find = new Random().Next(1, 50);
                if (find <= 10) {
                    Console.WriteLine("Wow! a treasure!");
                    money += 100;
                    Console.WriteLine($"Money:{money}");
                } else if (find >=30) {
                    Console.WriteLine("Monster! fight or flee?");
                    string chose = Console.ReadLine();
                    if (chose == "fight") {
                        Console.WriteLine("You win!");
                        money += 50;
                        Console.WriteLine($"Money:{money}");
                    } else if (chose == "flee") {
                        Console.WriteLine("Back to the start point!");
                        x = 0;
                        y = 0;
                        money/=2;
                        Console.WriteLine($"Money:{money}");
                        break;
                    } else {
                        Console.WriteLine("Invalid input, dead...");
                        money = 0;
                        x = 0;
                        y = 0;
                        Console.WriteLine("Back to the start point!");
                        Console.WriteLine("Money:0");
                        break;
                    }
                }
                if (x == 5 && y == 7) {
                    Console.WriteLine("You reached the exit door of the dungeon!");
                    Console.WriteLine($"Money:{money}");
                    playing = false;
                    break;
                }
            }
        } else if (start == 'n') {
            Console.WriteLine("Press 0 to quit game or press any other number to restart the game");
            int loop = Convert.ToInt32(Console.ReadLine());
            if (loop == 0) {
                playing = false;
            }
        }
    }
    Console.WriteLine("Game over!");
}

    }
}