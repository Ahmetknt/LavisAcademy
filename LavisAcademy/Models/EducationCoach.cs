using LavisAcademy.Models.Interface;

namespace LavisAcademy.Models
{
    public class EducationCoach : IEntity
    {
        public int Id { get; set; }
        public string WhatIs { get; set; }
        public string WhoIs { get; set; }
        public string WhoIsSuitableFor { get; set; }
        public string CoachingDuration { get; set; }
        public float PriceInfo { get; set; }
        public string Photo { get; set; }
    }
}
