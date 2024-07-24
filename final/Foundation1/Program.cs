using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Menu menu = new Menu();
        bool input = false;
        Video v1 = new Video("backscratchASMR", "HarryMan", 280);
        Video v2 = new Video("throwing 2-4 lead", "crazyBaseBall", 578);
        Comment c1 = new Comment("dirtyDan24", "you're bad at camera wrk");
        Comment c2 = new Comment("aweMan", "awesome video, would watch again");
        Comment c3 = new Comment("footsniffer", "good to see another enjoyer of the finer things");
        v1.AddComment(c1);
        v1.AddComment(c3);
        v2.AddComment(c2);
        v2.AddComment(c1);
        videos.Add(v1);
        videos.Add(v2);
        while (!input)
        {
            int response = 0;

            Video _video = new Video();
            _video.AddComment(c2);
            Console.Clear();
            response = menu.DisplayMenu();
            Console.Clear();

            if (response == 1)
            {
                _video.SetText();
                videos.Add(_video);
                Console.Write("Add a comment?(Y/N): ");
                string commentrespons = Console.ReadLine();
                if(commentrespons == "Y")
                {
                    _video.MakeComment();
                }
                else
                {
                    response = 0;
                }
            }
            else if (response == 2)
            {
                int count = 1;
                foreach (Video vid in videos)
                {
                    Console.Write($"{count}. ");
                    vid.Display();
                    vid.DisplayComments();
                    count++;
                }
                Console.Write("hit Enter to Continue");
                Console.ReadLine();
                response = 0;
            }
            else if (response == 3)
            {
                input = true;
            }
        }
    }
}