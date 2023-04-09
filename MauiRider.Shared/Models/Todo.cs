using System.Text.Json.Serialization;
using MauiRider.Shared.Interfaces;

namespace MauiRider.Shared.Models;

public class Todo: IApi
{
    public int userId { get; set; }
    public int id { get; set; }
    public string title { get; set; }
    public bool completed { get; set; }
    public bool isSuccess { get; set; }
    public List<string> Errors { get; set; }
}