// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.Design.Serialization;
using System.ComponentModel.Design;
using System.Collections;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.FileIO;
namespace MyApplication

{
    class Program
    {
        static void Main(string[] args)
        {
            // tiếng việt có dấu
            Console.OutputEncoding = Encoding.UTF8;
            // Khai bao kho video = list 

            List<Video> listVideo = new List<Video>();
            listVideo.Add(new Video("a", "a", "a", "a", "a", "a"));
            listVideo.Add(new Video("b", "b", "b", "b", "b", "b"));
            listVideo.Add(new Video("c", "c", "c", "c", "c", "c"));
            // step2: xử lý chức năng mà người dùng chọn 
            while (true)
            {
                try
                {
                    Console.WriteLine("===== Mời bạn chọn chức năng: =====");
                    Console.WriteLine("0.Dừng chương trình \n1.Thêm video \n2.Hiển thị kho video\n3.Xóa video\n4.Tìm kiếm bằng cách nhập tên video\n5.Kiểm tra số lượng video hiện có\n6.Cập nhật video \n7.Xóa video theo tên");
                    string luaChonSo = Console.ReadLine();

                    if (luaChonSo == "0")
                    {
                        break;
                    }
                    // Thêm video
                    else if (luaChonSo == "1")
                    {
                        Video v = Video.inputInfo();
                        listVideo.Add(v);
                    }
                    // Hiển thị thông tin video
                    else if (luaChonSo == "2")
                    {
                        Console.WriteLine("====Hiển thị thông tin kho video=====");
                        foreach (Video v in listVideo)
                        {
                            Console.WriteLine(v.getInformationVideo());
                        }
                    }
                    // Xóa video
                    else if (luaChonSo == "3")
                    {
                        Console.WriteLine("====Xóa video =====");
                        Console.WriteLine("Nhập vị trí cần xóa video:");
                        int viTriVideoCanXoa = Convert.ToInt32(Console.ReadLine());
                        listVideo.RemoveAt(viTriVideoCanXoa);
                    }
                    // Tìm kiếm video bằng tên
                    else if (luaChonSo == "4")
                    {
                        Console.WriteLine("====Tìm kiếm bằng cách nhập tên video ====");
                        Console.WriteLine("Nhập tên video cần tìm: ");
                        string nameVideo = Console.ReadLine();
                        if (listVideo.Where(w => w.nameVideo == nameVideo).Any())
                        {

                            Console.WriteLine("Video được tìm thấy là:" + nameVideo);
                        }
                        else
                        {
                            Console.WriteLine(" Video Không tìm thấy");
                        }
                    }
                    // kiểm tra số lượng video
                    else if (luaChonSo == "5")
                    {
                        Console.WriteLine("====Kiểm tra số lượng video =====");
                        Console.WriteLine("Số lượng video trong kho là: " + listVideo.Count());
                        foreach (Video v in listVideo)
                        {
                            Console.WriteLine(v.getInformationVideo());
                        }
                    }
                    // Cập nhật video
                    else if (luaChonSo == "6")
                    {
                        Console.WriteLine("====Cập nhật Video====");
                        Console.WriteLine("=== Mời bạn nhập tên Video thay đổi ====");
                        string nameVideo = Console.ReadLine();
                        Console.WriteLine("Cap Nhat AvatarChanel:");
                        string avatarChannelnew = Console.ReadLine();
                        Console.WriteLine("Cap nhat view Video:");
                        string viewVideoNew = Console.ReadLine();
                        Console.WriteLine("Cap nhat nameVideo: ");
                        string nameVideonew = Console.ReadLine();
                        Console.WriteLine("Cập nhật avatar Video: ");
                        string avatarVideonew = Console.ReadLine();
                        listVideo.Where(w => w.nameVideo == nameVideo).Select(s => { s.avatarChannel = avatarChannelnew; s.viewVideo = viewVideoNew; s.nameVideo = nameVideonew; s.avatarVideo = avatarVideonew; return s; }).ToList();
                    }
                    else if (luaChonSo == "7")
                    {
                        Console.WriteLine("====Xóa video theo tên====");
                        Console.WriteLine("Nhập tên video cần xóa: ");
                        string xoaVideo = Console.ReadLine();                      
                       for (int i = 0; i < listVideo.Count(); i++)
                        {
                            if (listVideo[i].nameVideo == xoaVideo) 
                            {                                
                                listVideo.RemoveAt(i);
                                Console.WriteLine("Video được xóa là:" + xoaVideo);
                                break;
                            }
                        }


                    }
                }
                catch (Exception ex)
                { Console.WriteLine("Code đã có lỗi xảy ra:" + ex); }
                
                }
                
            Channel c = new Channel(
             "btrann",
             "https://yt3.googleusercontent.com/ANLvpKDqDwu21odl58XTeRGBqMiyMPLHHGLuOakCB4ZNfs_Q-EhE2z2VIta1hTjTGCChR6xWMgY=s160-c-k-c0x00ffffff-no-rj",
              "7,95N",
              "93 Videos",
              "Trạm phát động lực study⏱️📚\r\n💗Đăng kí kênh nhé",
               true
              );
           /*   Console.WriteLine(c.channelName);
              Console.WriteLine(c.getInformationChannel());
              Console.WriteLine(c.channelName);
              c.setChannelName("Phan Hoang Nguyen");
              Console.WriteLine(c.channelName); */
        }

        private static int nameVideoNew(List<Video> listVideo, string? searchVideo)
        {
            throw new NotImplementedException();
        }
    }

    class Video  // lớp video
    {
        public String nameChannel;
        public String avatarChannel; // field
        public String timeVideo;
        public String viewVideo;
        public String nameVideo;
        public String avatarVideo;
        public Video(String newNameChannel, String newAvatarChannel, String newTimeVideo, String newViewVideo, String newNameVideo, String newAvatarVideo) // Contructor
        {
            nameChannel = newNameChannel;
            avatarChannel = newAvatarChannel;
            timeVideo = newTimeVideo;                     // fileld
            viewVideo = newViewVideo;
            nameVideo = newNameVideo;
            avatarVideo = newAvatarVideo;
        }
        public String getInformationVideo() { return nameChannel + "," + avatarChannel + "," + timeVideo + "," + viewVideo + "," + nameVideo + "," + avatarVideo; } // hàm get
        public void setVideoName(String newVideoName, String newAvatarVideo) // hàm set
        {
            nameVideo = newVideoName;
            avatarVideo = newAvatarVideo;
        }
        // Người dùng nhập thông tin video
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
            string tenVideoCanXoa= Console.ReadLine();
            Console.WriteLine("avatarVideo is: " + tenVideoCanXoa);

            //return new Video(ChannelName, avatarChannel, timeVideo, viewVideo, nameVideo, avatarVideo);
            Video v1 = new Video(ChannelName, avatarChannel, timeVideo, viewVideo, nameVideo, avatarVideo);
            return v1;
        }
    }

    // lớp channel
    class Channel
    {
        private String channelName;
        private String avatarChannel;
        private String sumNumberSubcriber; // filed
        private String numberVideo;
        private String channelIntroduction;
        private bool subcribe;
        public Channel(String newChannelName, String newAvatarChannel, String newSumNumberSubcriber, String newNumberVideo, String newChannelIntroduction, bool newSubcribe) // contructor
        {
            channelName = newChannelName;
            avatarChannel = newAvatarChannel;
            sumNumberSubcriber = newSumNumberSubcriber;
            numberVideo = newNumberVideo;
            channelIntroduction = newChannelIntroduction;
            subcribe = newSubcribe;
        }
        public String getInformationChannel() { return channelName + "," + avatarChannel + "," + sumNumberSubcriber + "," + numberVideo + "," + channelIntroduction + "," + subcribe; } // get lấy toàn bộ thông tin
        public void setChannelName(String newChannelName) // set
        {
            channelName = newChannelName;
        }
        Channel c = new Channel(
       "btrann",
      "https://yt3.googleusercontent.com/ANLvpKDqDwu21odl58XTeRGBqMiyMPLHHGLuOakCB4ZNfs_Q-EhE2z2VIta1hTjTGCChR6xWMgY=s160-c-k-c0x00ffffff-no-rj",
      "7,95N",
      "93 Videos",
      "Trạm phát động lực study⏱️📚\r\n💗Đăng kí kênh nhé",
      true
     );
         /* Console.WriteLine(c.channelName);
          Console.WriteLine(c.getInformationChannel());
          Console.WriteLine(c.channelName);
           c.setChannelName("Phan Hoang Nguyen");
           Console.WriteLine(c.channelName); */

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

