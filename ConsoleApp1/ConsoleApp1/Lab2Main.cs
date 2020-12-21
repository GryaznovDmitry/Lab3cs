using System;

namespace GryaznovLab3
{
    public class Lab2Main
    {
        static void Main()
        {

            Console.WriteLine("\n\nLab 3\n");
            V5MainCollection MC3 = new V5MainCollection();
            MC3.DataChanged += OnDataChanged;
            MC3.AddDefaults();

            MC3[0] = new V5DataCollection("MainCollection", new DateTime());
            MC3[0].infodata = "Recieve Zachet 5 :)";
            MC3.Remove("Recieve Zachet 5 :)", MC3[0].time);
        }

        static void OnDataChanged(object source, DataChangedEventArgs args)
        {
           Console.WriteLine(args);
        }
    }
}
