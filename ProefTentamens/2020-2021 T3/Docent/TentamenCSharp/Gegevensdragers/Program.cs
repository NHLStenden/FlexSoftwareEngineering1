using System;
using Gegevensdragers.classes;

namespace Gegevensdragers
{
    class Program
    {
        static void Main(string[] args)
        {
            OpslagVerzameling verzameling = new OpslagVerzameling();
            
            
            USBStick usb1 = new USBStick("Kingston", "8GB", false);
            USBStick usb2 = new USBStick("WD", "16GB", true);
            USBStick usb3 = new USBStick("XYZ", "32GB", false );
            
            SDCard sd1 = new SDCard("Telefoon Martin", "32GB", "microSD");
            SDCard sd2 = new SDCard("Telefoon Piet", "32GB", "microSD");
            SDCard sd3 = new SDCard("Telefoon Klaas", "64GB", "full");
            
            Harddisk hdd1 = new Harddisk("sda", "1TB", "3,5");
            Harddisk hdd2 = new Harddisk("sdb", "1TB", "2,5");
            
            SolidStateDisk sdd1 = new SolidStateDisk("sdc","60GB", "500MB/s");
            SolidStateDisk sdd2 = new SolidStateDisk("sdd","60GB", "500MB/s");

            DVD dvd1 = new DVD("Back to the future");
            DVD dvd2 = new DVD("Edge of tomorrow");

            verzameling.add(usb1).add(usb2).add(usb3).add(sd1).add(sd2).add(sd3).add(hdd1).add(hdd2).add(sdd1).add(sdd2).add(dvd1).add(dvd2);
            verzameling.report();
        }
    }
}