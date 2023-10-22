using System;
using System.Threading;

namespace Advanced.Events
{
    class Encoder  //Setting up a sender - Publisher
    {
        /*
         * Pass an Event Steps (Publisher):
         * 1 - Define a delegate
         * 2 - Define an event on that delegate
         * 3 - Raise an event 
         */

        //Originally EventArgs instead of VideoEventArgs - //Any method must pass this signature to be call for the delegate

        /*

        public delegate void VideoEncoderEventHandler(Object source, VideoEventArgs args); 
        public event VideoEncoderEventHandler VideoEncoded;

        */

        //Alternatively you can pass an Event Hanlder insetead of a delegate 
        /*
             You can avoid placing a delegate every time you want to pass an event 
            by simply passing an EventHandler<TypeOFEvent> instead
             */
        public EventHandler<VideoEventArgs> VideoEncoded;

        /// <summary>
        /// Method to call encoder to encode a video
        /// </summary>
        /// <param name="video">Pass a video</param>
        public void VideoEncode(Video video)
        {
            Console.WriteLine("Encoding a video: " + video.Title);
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

        // Use the event VideoEncoded LN:26 
        protected virtual void OnVideoEncoded(Video video) //Use the same name as the event with "On" at the beggining
        {
            if(VideoEncoded != null) //Passing the event
                VideoEncoded(this, new VideoEventArgs(){Video = video}); // pass this object (Encoder) 
        }
    }
}