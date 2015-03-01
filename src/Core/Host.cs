using System;

namespace Core
{
    public class Host
    {
        private string _hostname;
        private string _playlistHome;

        public string Hostname
        {
            get { return _hostname ?? (_hostname = Environment.MachineName); }
            set { _hostname = value; }
        }

        public string PlaylistHome
        {
            get
            {
                if (_playlistHome == null)
                {
                    throw new InvalidOperationException("Playlist not set");
                }
                return _playlistHome;
            }
            set { _playlistHome = value; }
        }
    }
}
