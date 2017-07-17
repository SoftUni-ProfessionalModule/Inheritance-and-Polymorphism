namespace OnlineRadioDatabase
{
    using System;

    public class Song
    {
        private string artist;
        private string songTitle;
        private int minutes;
        private int seconds;
        
        public Song(string artist, string songTitle, int minutes, int seconds)
        {
            this.Artist = artist;
            this.SongTitle = songTitle;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public string Artist
        {
            get { return this.artist; }
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
                }

                this.artist = value;
            }
        }

        public string SongTitle
        {
            get { return this.songTitle; }
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new ArgumentException("Song name should be between 3 and 30 symbols.");
                }

                this.songTitle = value;
            }
        }

        public int Minutes
        {
            get { return this.minutes; }
            set
            {
                if (value < 0 || value > 14)
                {
                    throw new ArgumentException("Song minutes should be between 0 and 14.");
                }

                this.minutes = value;
            }
        }

        public int Seconds
        {
            get { return this.seconds; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("Song seconds should be between 0 and 59.");
                }

                this.seconds = value;
            }
        }
    }
}