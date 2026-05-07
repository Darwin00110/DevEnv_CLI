using System.Diagnostics;
using WindowsInput;
using WindowsInput.Native;
public class Program
{
    public static void OpenWebSite(string url)
    {
        var processo = new ProcessStartInfo
        {
          FileName = url,
          UseShellExecute = true  
        };
        Process.Start(processo);
    }
    public static void OpenVscode()
    {
        var processo = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            Arguments = "/c code -r",
            UseShellExecute = false
        };
        Process.Start(processo);
    }
    public async static Task DevAutomation()
    {
        var robot = new InputSimulator();
        OpenWebSite("https://discord.com/channels/@me/1343005974390374434");
        await Task.Delay(1 * 1000);
        OpenWebSite("https://gemini.google.com/app");
        await Task.Delay(1 * 1000);
        OpenWebSite("https://github.com/");
        await Task.Delay(1 * 1000);
        OpenWebSite("https://noises.online/");
        await Task.Delay(1 * 1000);
        robot.Mouse.MoveMouseTo(11 * 1000, 30 * 1000);
        robot.Mouse.LeftButtonClick();
        await Task.Delay(1 * 1000);
        robot.Mouse.MoveMouseTo(37.5 * 1000, 52 * 1000);
        robot.Mouse.LeftButtonClick();
        
        OpenVscode(); 
    }
    public static async Task Main(string[] args)
    {
        await DevAutomation();
    }
}
