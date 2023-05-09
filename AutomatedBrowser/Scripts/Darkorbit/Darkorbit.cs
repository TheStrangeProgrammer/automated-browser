using AutomatedBrowser.Scripts;
using AutomatedBrowser.Scripts.Utils;
using System;
using System.Drawing;
using System.Threading.Tasks;

public class Darkorbit : Script
{
    private Browser mainBrowser;
    private Browser gameBrowser;
    public Darkorbit()
    {

    }
    public override void Init()
    {

        mainBrowser = scriptUI.CreateBrowser("Main Browser");

        gameBrowser = scriptUI.CreateBrowser("Game Browser");


        scriptUI.CreateButton("screenshot", screenshot_Click);
    }

    public override async void Start()
    {

        Console.WriteLine("works");
    }


    public override async void Loop()
    {

    }

    private async void screenshot_Click(object sender, EventArgs e)
    {

        await mainBrowser.GetPID();
    }

}
