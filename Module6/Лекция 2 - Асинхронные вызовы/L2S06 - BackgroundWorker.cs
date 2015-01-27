using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;


class L2S06
{
    public static void MainX()
    {
        var worker = new BackgroundWorker();
        worker.DoWork += new DoWorkEventHandler(Computation);
        worker.ProgressChanged += new ProgressChangedEventHandler(ShowProgress);
        worker.WorkerReportsProgress = true;
        worker.WorkerSupportsCancellation = true;
        worker.RunWorkerAsync();
        Console.WriteLine("Process started");
        while (worker.IsBusy)
        {
            if (Console.KeyAvailable)
            {
                worker.CancelAsync();
                Console.Write("\nProcess aborted");
                break;
            }
        }
        Console.WriteLine("\nProcess finished");
    }

    static void ShowProgress(object sender, ProgressChangedEventArgs e)
    {
        Console.Write("\r" + e.ProgressPercentage + "%");
    }

    static void Computation(object sender, DoWorkEventArgs e)
    {
        double a=1;
        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < 1000000; j++)
                a /= 1.001;
            (sender as BackgroundWorker).ReportProgress(i);
        }
    }
}