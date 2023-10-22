using System;

namespace Advanced.Events
{
    //Another event args to pass a video
    class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}