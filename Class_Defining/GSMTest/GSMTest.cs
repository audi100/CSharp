using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

namespace GSMTest
{
    class GSMTest
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            GSM Nokia=new GSM("Nokia","NN",250, "Gogo", new Battery("82L", 12,10, BatteryType.LiIon), new Display(20,64));
            GSM HTC = new GSM("HTC", "NK", 130, "Na", new Battery("K9092", 26, 9, BatteryType.NiCd), new Display(10, 128));
            GSM Motorolla = new GSM("Motorolla", "NKH", 10, "Na", new Battery("L92", 13, 3, BatteryType.NiMH), new Display(12, 1024));

            GSM[] gsms=new GSM[]{Nokia, HTC, Motorolla};
            foreach (GSM phone in gsms)
            {
                Console.WriteLine(phone.ToString());
                Console.WriteLine();
            }
            Console.WriteLine(GSM.IPhone4s);

        }
    }
}
