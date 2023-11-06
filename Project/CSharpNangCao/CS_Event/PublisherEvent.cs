using System;

namespace CS_Event
{
    public class MyEvent : EventArgs
    {
        public MyEvent (string data)
        {
            this.data = data;
        }
        // Lưu dữ liệu gửi đi từ publisher
        private string data;

        public string Data 
        {
            get { return data; }
        }
    }

    public class ClassA 
    {
        // Tạo Event với EventHandler
        public event EventHandler<MyEvent> event_news;

        public void Send () {
            event_news?.Invoke(this, new MyEvent("Có tin mới Abc ..."));
        }
    }

    public class ClassB 
    {
        public void Sub (ClassA p)
        {
            p.event_news += ReceiverFromPublisher;
        }

        private void ReceiverFromPublisher(object sender, MyEvent e)
        {
            Console.WriteLine ("ClassB: " + e.Data);
        }
    }


    public class ClassC 
    {
        public void Sub (ClassA p)
        {
            p.event_news += ReceiverFromPublisher;
        }

        private void ReceiverFromPublisher(object sender, MyEvent e)
        {
            Console.WriteLine ("ClassC: " + e.Data);
        }
    }
}