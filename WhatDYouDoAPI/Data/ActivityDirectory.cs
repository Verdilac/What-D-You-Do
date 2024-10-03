using WhatDYouDoAPI.Models;

namespace WhatDYouDoAPI.Data;

public class ActivityDirectory
{
    public static List<Activity> Activities  = new List<Activity>
    {
        new Activity{Id=1,
            Name="Unreal Work",
            StartTime =TimeOnly.FromDateTime(DateTime.Now),
            EndTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
            Date = DateOnly.FromDateTime(DateTime.Today)},
        new Activity{Id=2,
            Name="DotNET Work",
            StartTime =TimeOnly.FromDateTime(DateTime.Now),
            EndTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
            Date = DateOnly.FromDateTime(DateTime.Today)}
    };

    public static List<Tag> Tags = new List<Tag>()
    {
        new Tag { Id = 1, Name = "Unreal" },
        new Tag { Id = 1, Name = "DotNet" }

    };


}