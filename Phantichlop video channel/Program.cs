// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
namespace MyApplication
{
    class Video
    {
        private String nameChannel;
        private String avatarChannel;
        private String timeVideo;
        private String viewVideo;
        private String nameVideo;
        private String avatarVideo;
        public Video(String newNameChannel, String newAvatarChannel, String newTimeVideo, String newViewVideo, String newNameVideo, String newAvatarVideo)
        {
            nameChannel = newNameChannel;
            avatarChannel = newAvatarChannel;
            timeVideo = newTimeVideo;
            viewVideo = newViewVideo;
            nameVideo = newNameVideo;
            avatarVideo = newAvatarVideo;
        }
        public String getInformationVideo() { return nameChannel + "," + avatarChannel + "," + timeVideo + "," + viewVideo + "," + nameVideo + "," + avatarVideo; }
        public void setVideoName(String newVideoName)
        {
            nameVideo = newVideoName;
        }
   
        class Channel
        {
            private String channelName;
            private String avatarChannel;
            private String sumNumberSubcriber;
            private String numberVideo;
            private String channelIntroduction;
            private bool subcribe;
            public Channel(String newChannelName, String newAvatarChannel, String newSumNumberSubcriber, String newNumberVideo, String newChannelIntroduction, bool newSubcribe)
            {
                channelName = newChannelName;
                avatarChannel = newAvatarChannel;
                sumNumberSubcriber = newSumNumberSubcriber;
                numberVideo = newNumberVideo;
                channelIntroduction = newChannelIntroduction;
                subcribe = newSubcribe;
            }
            
            {
                Console.WriteLine("ChannelName: ");
                string ChannelName = Console.ReadLine();
                Console.WriteLine("ChannelName is: " + ChannelName);
                Console.WriteLine("avatarChannel: ");
                string avatarChannel = Console.ReadLine();
                Console.WriteLine("avtarChannel is: " + avatarChannel);
                Console.WriteLine("TimeVideo: ");
                string timeVideo = Console.ReadLine();
                Console.WriteLine("TimeVideo is: " + timeVideo);
                Console.WriteLine("ViewVideo: ");
                string viewVideo = Console.ReadLine();
                Console.WriteLine("viewVideo is: " + viewVideo);
                Console.WriteLine("nameVideo:");
                string nameVideo = Console.ReadLine();
                Console.WriteLine("nameVideo is: " + nameVideo);
                Console.WriteLine("avatarVideo: ");
                string avatarVideo = Console.ReadLine();
                Console.WriteLine("avatarVideo is: " + avatarVideo);
            }

            public String getInformationChannel() { return channelName + "," + avatarChannel + "," + sumNumberSubcriber + "," + numberVideo + "," + channelIntroduction + "," + subcribe; }
            public void setChannelName(String newChannelName)
            {
                channelName = newChannelName;
            }       
            class Program
            {
                     static void Main(string[] args)
                     {
                        Video v = new Video("ChannelName",
                            "https://yt3.googleusercontent.com/ANLvpKDqDwu21odl58XTeRGBqMiyMPLHHGLuOakCB4ZNfs_Q-EhE2z2VIta1hTjTGCChR6xWMgY=s160-c-k-c0x00ffffff-no-rj",
                            "16:04",
                            "73N",
                            "[Động lực học tập] Hãy sống đúng với ước mơ của bạn",
                            "https://youtu.be/brXyzK0yQbU?t=13"
                            );
                        Console.OutputEncoding = Encoding.UTF8;
                        Console.WriteLine(v.nameVideo);
                        Console.WriteLine(v.nameChannel);
                        Console.WriteLine(v.getInformationVideo());
                        v.setVideoName("Hãy cố gắng làm tốt nhất những gì bạn có thể");
                        Console.WriteLine(v.nameVideo);
                        Channel c = new Channel(
                            "btrann",
                            "https://yt3.googleusercontent.com/ANLvpKDqDwu21odl58XTeRGBqMiyMPLHHGLuOakCB4ZNfs_Q-EhE2z2VIta1hTjTGCChR6xWMgY=s160-c-k-c0x00ffffff-no-rj",
                            "7,95N",
                            "93 Videos",
                            "Trạm phát động lực study⏱️📚\r\n💗Đăng kí kênh nhé",
                            true
                            );
                        Console.WriteLine(c.channelName);
                        Console.WriteLine(c.getInformationChannel());
                        Console.WriteLine(c.channelName);
                        c.setChannelName("Phan Hoang Nguyen");
                        Console.WriteLine(c.channelName);
                    }
            }
        }
    }

}

