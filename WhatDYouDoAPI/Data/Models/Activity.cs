namespace WhatDYouDoAPI.Models;

public class Activity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public DateOnly Date { get; set; }
    
}