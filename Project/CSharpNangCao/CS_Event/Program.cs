using System;
using CS_Event;

namespace CS_Event
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dùng delegate
            PublisherDelegate p = new PublisherDelegate();
            PublisherA sa = new PublisherA();
            PublisherB sb = new PublisherB();

            sa.Sub(p);
            sb.Sub(p);

            p.Send(); //Kết quả: SubscriberB: Co tin moi
            /*
            Phân tích vấn đề của đoạn mã trên:

            Lớp Publisher xây dựng một delegate có tên NotifyNews và khai báo thuộc tính event_news triển khai nó, 
            khi Publisher thi hành Send() nó sẽ thi hành delegate này và 
            như vậy những đối tượng nào đăng ký vào delegate sẽ có cơ hội nhận thông tin mới từ Publisher

            Hai lớp PublisherA và PublisherB tiến hành đăng ký phương thức ReceiverFromPublisher vào Delegate của Pushisher, 
            và như vậy khi chạy code đã có kết quả như trên.

            Tuy nhiên, nhìn vào phương thức public void Sub(Publisher p) của SubscriberB thì đoạn mã:

            p.event_news = null;
            Nó đã gán event_news bằng null, có nghĩa là việc đăng ký của SubcriberA lúc trước bị loại bỏ bởi SubcriberB, 
            dẫn tới chỉ có SubcriberB nhận được tin mới. 
            Điều này là phá hỏng nguyên tắc hoạt động của mô hình lập trình sự kiện - phá vỡ sự đóng gói

            Để giải quyết vấn đề trên, 
            thật đơn giản với .NET chỉ cần thêm từ khóa EVENT vào định nghĩa event_news của Pushliser, 
            và từ đây event_news gọi là Event chứ không còn gọi là Delegate
            */
            //Event
            /*
            Event là Delegate nhưng khi khai báo thêm từ khóa event, 
            dẫn tới chỉ có thể thực hiện toán tử += hoặc -= với Event
            */
            ClassA pEvent  = new ClassA();
            ClassB sAEvent = new ClassB();
            ClassC sBEvent = new ClassC();

            sAEvent.Sub(pEvent); // sa đăng ký nhận sự kiện từ p
            sBEvent.Sub(pEvent); // sb đăng ký nhận sự kiện từ p

            pEvent.Send();

        }
    }
}
