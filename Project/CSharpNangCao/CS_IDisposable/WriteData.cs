using System;
using System.IO;

namespace CS_IDisposable
{
    class WriteData : IDisposable
    {
         // trường lưu trạng thái Dispose
        private bool m_Disposed = false;
        private StreamWriter stream;

        public WriteData(String fileName)
        {
            stream = new StreamWriter(fileName, true);
        }

        // Phương thức triển khai từ giao diện
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize (this);
        }

        // Nếu disposing = true -> Được thi hành do gọi trực tiếp (do Dispose gọi)
        // tài nguyên managed, unmanaged được giải phóng
        // nếu disposing = fale -> Được thi hành bởi phương thức hủy, chỉ cần giải phóng
        // các toàn nguyên unmanaged.
        protected virtual void Dispose (bool disposing) {
            if (!m_Disposed) {
                if (disposing) {
                    // các đối tượng có Dispose gọi ở đây
                    stream.Dispose();
                }

                // giải phóng các tài nguyên không quản lý được cửa lớp (unmanaged)

                m_Disposed = true;
            }
        }

        ~WriteData () {
            Dispose(false);
        }
    }
}