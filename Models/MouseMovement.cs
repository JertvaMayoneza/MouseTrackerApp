using System;

namespace MouseTrakerApp.Data
{
    public class MouseMovement
    {
        public int Id { get; set; } // �������������
        public string CoordinatesJson { get; set; } // JSON ���������
        public DateTime Timestamp { get; set; } // �����
    }
}
