using System;

namespace CS_Event
{
    /*
        Publisher là lớp phát đi sự kiện, bằng cách gọi
        một deleage trong phương thức Send
    */
    class PublisherDelegate
    {
        public delegate void NotifyNews (object data);

        public NotifyNews event_news;

        public void Send () {
            event_news?.Invoke ("Co tin moi");
        }
    }

    class PublisherA
    {
        public void Sub (PublisherDelegate p) {
            p.event_news += ReceiverFromPublisher;
        }

        void ReceiverFromPublisher (object data) {
            Console.WriteLine ("SubscriberA: " + data.ToString ());
        }
    }
    class PublisherB
    {
        public void Sub (PublisherDelegate p) {
            p.event_news = null;  // Hủy các đối tượng khác nhận sự kiện
            p.event_news += ReceiverFromPublisher;
        }

        void ReceiverFromPublisher (object data) {
            Console.WriteLine ("SubscriberB: " + data.ToString ());
        }
    }
}