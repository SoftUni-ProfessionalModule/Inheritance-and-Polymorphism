namespace OnlineRadioDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class OnlineRadioDatabase
    {
        public static void Main()
        {
            var numberOfSongs = int.Parse(Console.ReadLine());
            var songsList = new List<Song>();
            var totalSeconds = 0;
            var songValidation = new Regex(@"^[^;]+;[^;]+;\d+:\d+$");

            for (int i = 0; i < numberOfSongs; i++)
            {
                var inputLine = Console.ReadLine();
                if (songValidation.IsMatch(inputLine))
                {
                    var songInfo = inputLine.Split(';');
                    var artistName = songInfo[0];
                    var songTitle = songInfo[1];
                    var time = songInfo[2].Split(':');
                    int minutes;
                    int seconds;

                    try
                    {
                        if (int.TryParse(time[0], out minutes) && int.TryParse(time[1], out seconds))
                        {
                            var currentSong = new Song(artistName, songTitle, minutes, seconds);
                            Console.WriteLine("Song added.");
                            songsList.Add(currentSong);
                            totalSeconds += (minutes * 60) + seconds;
                        }
                        else
                        {
                            throw new ArgumentException("Invalid song length.");
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid song.");
                }
            }

            Console.WriteLine($"Songs added: {songsList.Count}");
            var songsLenght = TimeSpan.FromSeconds(totalSeconds);
            Console.WriteLine($"Playlist length: {songsLenght.Hours}h {songsLenght.Minutes}m {songsLenght.Seconds}s");
        }
    }
}