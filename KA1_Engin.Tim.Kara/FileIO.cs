using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace KA1_Engin.Tim.Kara
{
    // Utility class : Kun statiske metoder
    public class FileIO
    {
        public static void WriteFile(ArrayList al, string filename)
        {
            // Hvor skriver vi, hvilke betingelser
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
            // Hvordan skriver vi : En binær fil
            BinaryFormatter bf = new BinaryFormatter();
            // Skriv filen : Lav objekter om til lange serier af data
            bf.Serialize(fs, al);
            // Ryd op
            fs.Close();
        }

        public static ArrayList ReadFile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryFormatter bf = new BinaryFormatter();
            // læs filen : Lav lange serier af data om til objekter med referencer
            ArrayList al = (ArrayList)bf.Deserialize(fs);
            fs.Close();
            return al;
        }
    }
}