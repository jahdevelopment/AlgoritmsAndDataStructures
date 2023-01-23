﻿
using System.Security.Principal;

Console.WriteLine("|||||||||||||||||||||||||||||| MUSIC PLAYER ||||||||||||||||||||||||||||||\n");


Queue<string> playList = new Queue<string>();

int menu = 0;

bool continueRunning = true;

string addSong = "";

string nowPlaying = "";

string nextToPlay = "";

string previousSong = "";


while (continueRunning)
{
    ///////// MAIN MENU

    Console.WriteLine("\nChoose an option:\n\n  1. Add a song to your playlist\n  2. Play the next song in your playlist\n  3. Skip the next song\n  4. Rewind one song\n  5. Exit\n");

    menu = Int32.Parse(Console.ReadLine());

    string[] playListArray = playList.ToArray();

    //Console.WriteLine("\nChoose an option:\n\n  1. Add a song to your playlist\n  2. Play the next song in your playlist\n  3. Skip the next song\n  4. Rewind one song\n  5. Exit\n");

    //menu= Int32.Parse(Console.ReadLine());

    if (menu == 1)
    {
        //////// START ADDING SONGS TO THE PLAYLIST

        Console.Write("Enter Song Name: > ");

        addSong = Console.ReadLine();

        while (addSong.Length < 3)
        {
            Console.WriteLine("Enter a song name with a ninimum of 3 characters");

            addSong = Console.ReadLine();
        }

        playList.Enqueue(addSong);

        Console.WriteLine($"\n\"{addSong}\" added to your playlist");

        if (playList.Count >= 1)
        {
            nextToPlay = playList.Peek();

            Console.WriteLine($"Next song to play - \"{nextToPlay}\"\n");
        }
    }
    else if (menu == 2)
    {
        ///////////// PLAY THE PLAYLIST

        if (playList.Count == 0)
        {
            Console.WriteLine("you don't have songs in your playlist, first go to option 1 of the menu and add some songs");
        }
        else if (playList.Count == 1)
        {
            nowPlaying = playList.Dequeue();

            Console.WriteLine($"\nNow playing \"{nowPlaying}\'");

            Console.WriteLine($"Next song - none queued\r\n\r\n. . . // add more songs");
        }
        else if (playList.Count >= 1)
        {
            nowPlaying = playList.Dequeue();

            Console.WriteLine($"\nNow playing \"{nowPlaying}\'");

            nextToPlay = playList.Peek();

            Console.WriteLine($"Next song - \"{nextToPlay}\"\n");
            
        }
    }
    else if (menu == 3)
    {
        if (playList.Count < 3)
        {
        
        }
    }
    else if (menu == 4)
    {

    }
    else if (menu == 5)
    {
        Console.WriteLine("Closing the Music Player, bye!");

        continueRunning = false;
    }
    else
    {
        Console.WriteLine("Invalid selection, try again!");
        //Console.WriteLine("Choose an option:\n\n  1. Add a song to your playlist\n  2. Play the next song in your playlist\n  3. Skip the next song\n  4. Rewind one song\n  5. Exit\n");
    }
    
    


    
}


