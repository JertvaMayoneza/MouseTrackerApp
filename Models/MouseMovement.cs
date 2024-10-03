using System;

namespace MouseTrakerApp.Data
{
    public class MouseMovement
    {
        public int Id { get; set; } // Идентификатор
        public string CoordinatesJson { get; set; } // JSON координат
        public DateTime Timestamp { get; set; } // Время
    }
}
