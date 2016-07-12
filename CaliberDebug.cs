using GTA;
using System;
using System.Windows.Forms;

public class CaliberDebug : Script
{
    public CaliberDebug()
    {
        Tick += OnTick;
        KeyDown += OnKeyDown;
        KeyUp += OnKeyUp;

        Interval = 10; /* loop to check, ms */
    }

    void OnTick(object sender, EventArgs e)
    {

    }
    void OnKeyDown(object sender, KeyEventArgs e)
    {

    }
    void OnKeyUp(object sender, KeyEventArgs e)
    {

    }
}
