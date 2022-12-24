using System;
using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string GoesBy { get; set; }
    public string Email { get; set; }
    public int StylistId { get; set; }
    public Stylist Stylist { get; set; }
  }
}