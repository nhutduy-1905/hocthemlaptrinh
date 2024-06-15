﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace MyApplication

{
    class Program
    {
        static void Main(string[] args)
        {

            // Khai bao kho video = list 
            List<Video> listVideo = new List<Video>();
            // step2: xử lý chức năng mà người dùng chọn 
            while (true)
            {
                Console.WriteLine("===== Mời bạn chọn chức năng: =====");
                Console.WriteLine("0. Dừng chương trình \n 1. Thêm video");
                string luaChonSo = Console.ReadLine();
                if (luaChonSo == "0")
                {
                    break;
                }
                else if (luaChonSo == "1")
                {
                    Video v = Video.inputInfo();
                    listVideo.Add(v);
                }
            }
            Console.WriteLine("===== Mời bạn chọn chức năng: =====");
            Console.WriteLine("1. Thêm video");
            Video v1 = Video.inputInfo();
            Video v2 = Video.inputInfo();
            listVideo.Add(v1);
            listVideo.Add(v2);
            Console.WriteLine("Số lượng video trong kho: " + listVideo.Count());

            //  step4: hiển thị toàn bộ thông tin khi video = for 
            Console.WriteLine("===== Hiển thị thông tin kho video =====");
            foreach (Video v in listVideo)
            {
                Console.WriteLine(v.getInformationVideo());
            }
            Console.WriteLine("==========");
            Console.WriteLine("=====Chuc nang xoa video======");
            listVideo.Remove(v1);
            Console.WriteLine("So luong video con lai trong kho la: " + listVideo.Count());
            Console.WriteLine("==========");
            Console.WriteLine("=====Tim kiem video======");
            Console.WriteLine("Nhap video tim kiem: ");
            string name = Console.ReadLine();
            while (true)

            {
                if (name == v)
                {
                    Console.WriteLine("Tim kiem thay video trong kho");
                }
                else
                {
                    Console.WriteLine("Khong tim thay video trong kho");
                }
            }
        }
        
        class Video
        {
            public String nameChannel;
            public String avatarChannel;
            public String timeVideo;
            public String viewVideo;
            public String nameVideo;
            public String avatarVideo;
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
            public static Video inputInfo()
            {
                Console.WriteLine("ChannelName: ");
                string ChannelName = Console.ReadLine();
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

                //return new Video(ChannelName, avatarChannel, timeVideo, viewVideo, nameVideo, avatarVideo);
                Video v1 = new Video(ChannelName, avatarChannel, timeVideo, viewVideo, nameVideo, avatarVideo);
                return v1;
            }
        }


        class Channel
        {
            public String channelName;
            public String avatarChannel;
            public String sumNumberSubcriber;
            public String numberVideo;
            public String channelIntroduction;
            public bool subcribe;
            public Channel(String newChannelName, String newAvatarChannel, String newSumNumberSubcriber, String newNumberVideo, String newChannelIntroduction, bool newSubcribe)
            {
                channelName = newChannelName;
                avatarChannel = newAvatarChannel;
                sumNumberSubcriber = newSumNumberSubcriber;
                numberVideo = newNumberVideo;
                channelIntroduction = newChannelIntroduction;
                subcribe = newSubcribe;
            }
            public String getInformationChannel() { return channelName + "," + avatarChannel + "," + sumNumberSubcriber + "," + numberVideo + "," + channelIntroduction + "," + subcribe; }
            public void setChannelName(String newChannelName)
            {
                channelName = newChannelName;
            }
        }
    }
}

// class Program

// {
  //  static void Main(string[] args)
   // {

        // Khai bao kho video = list 
       // List<Video> listVideo = new List<Video>();
        // step2: xử lý chức năng mà người dùng chọn 
      //  while (true)
       // {
       //     Console.WriteLine("===== Mời bạn chọn chức năng: =====");
         //   Console.WriteLine("0. Dừng chương trình \n 1. Thêm video");
         //   string luaChonSo = Console.ReadLine();
         //   if (luaChonSo == "0")
          //  {
          //      break;
          //  }
         //   else if (luaChonSo == "1")
         //   {
         //       Video v = Video.inputInfo();
         //       listVideo.Add(v);
          //  }
       // }
      //  Console.WriteLine("===== Mời bạn chọn chức năng: =====");
      //  Console.WriteLine("1. Thêm video");
       // Video v1 = Video.inputInfo();
       // Video v2 = Video.inputInfo();

        // step3: thêm video vào kho video 

       // listVideo.Add(v1);
      //  listVideo.Add(v2);
      //  Console.WriteLine("Số lượng video trong kho: " + listVideo.Count());
      //  Video v = new Video("btrann",
      //     "https://yt3.googleusercontent.com/ANLvpKDqDwu21odl58XTeRGBqMiyMPLHHGLuOakCB4ZNfs_Q-EhE2z2VIta1hTjTGCChR6xWMgY=s160-c-k-c0x00ffffff-no-rj",
       //    "16:04",
         //  "73N",
      //     "[Động lực học tập] Hãy sống đúng với ước mơ của bạn",
     //      "https://youtu.be/brXyzK0yQbU?t=13");


     //   Console.OutputEncoding = Encoding.UTF8;
     //   Console.WriteLine(v.nameVideo);
      //  Console.WriteLine(v.nameChannel);
      //  Console.WriteLine(v.getInformationVideo());
      //  v.setVideoName("Hãy cố gắng làm tốt nhất những gì bạn có thể");
     //   Console.WriteLine(v.nameVideo);
      //  Video v1 = Video.inputInfo();
      //  listVideo.Add(v1);
      //  Console.WriteLine(v1.getInformationVideo());
      //  listVideo.Remove(v);
        // Console.WriteLine(listVideo);
      //  Console.WriteLine("Danh sách video đã xóa:" + listVideo);
      //  Channel c = new Channel(
      //      "btrann",
      //      "https://yt3.googleusercontent.com/ANLvpKDqDwu21odl58XTeRGBqMiyMPLHHGLuOakCB4ZNfs_Q-EhE2z2VIta1hTjTGCChR6xWMgY=s160-c-k-c0x00ffffff-no-rj",
      //      "7,95N",
      //      "93 Videos",
      //      "Trạm phát động lực study⏱️📚\r\n💗Đăng kí kênh nhé",
      //      true
       //     );
      //  Console.WriteLine(c.channelName);
      //  Console.WriteLine(c.getInformationChannel());
      //  Console.WriteLine(c.channelName);
      //  c.setChannelName("Phan Hoang Nguyen");
      //  Console.WriteLine(c.channelName);
   // }
//}
 
    