using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula24Excessoes.Resolucao1
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

            public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
            {
                RoomNumber = roomNumber;
                CheckIn = checkIn;
                CheckOut = checkOut;
            }
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;//totalde dias
        }
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public override string ToString()
        {
            return "Room " + RoomNumber + ", check-in: " + CheckIn.ToString("dd/MM/yyyy") + ", check-out: " + CheckOut.ToString("dd/MM/yyyy") + ", " + Duration() + " nights";  
        }

    }
}