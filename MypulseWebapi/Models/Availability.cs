using System;
using System.Collections.Generic;

namespace MypulseWebapi.Models
{
    public class Availability
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int SlotDuration { get; set; }
        public int PaymentCharges { get; set; }
        public string Timezone { get; set; }
        public string MeetLocationId { get; set; }
        public string PaymentStatus { get; set; }
        public string AdditionalInstructions { get; set; }
        public string MaxBookedSlots { get; set; }
        public string AvailabilityJSON { get; set; }
        public string ExcludedDateConfig { get; set; } 
        public string AdditionalInfo { get; set; } 
        public List<AppointmentMode> AppointmentModes { get; set; }
        public string BookingPeriod { get; set; }
        public string Notes { get; set; }
        public string ManagerID { get; set; }
        public Manager Manager { get; set; }
    }

    public enum AppointmentMode
    {
        OFFLINE,
        ONLINE
    }

}
