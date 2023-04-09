namespace MauiRider.Shared.Interfaces;

public interface IApi
{
    public bool isSuccess { get; set; }
    public List<string> Errors { get; set; }
}