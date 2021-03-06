﻿using System;
using System.Collections.Generic;

namespace Community.Models
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool Home { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<Event> Events { get; set; }

        public string FullAddress =>
            $"{Street}{(string.IsNullOrEmpty(Street2) ? string.Empty : $" {Street2}")}, {City}, {State} {ZipCode}";
    }
}