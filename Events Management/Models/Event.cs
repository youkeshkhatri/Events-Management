using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;

namespace Events_Management.Models;

public partial class Event
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]
    public string? Email { get; set; }

    [Required]
    public string? Subject { get; set; }

    [Required]
    public string? Message { get; set; }
}
