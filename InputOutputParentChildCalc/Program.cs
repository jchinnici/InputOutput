using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputParentChildCalc
{
    class Program
    {
        static List<Record> database = new List<Record>();
        static void Main(string[] args)
        {
            var currentFileData = File.ReadAllText("input.txt");

            Extrapolate(currentFileData);
            


            

            


            
            //File.WriteAllText("input.txt", sb.ToString());
            Console.WriteLine(File.ReadAllText("input.txt"));
            Console.Read();
        }
        static void LoadDataBase(string text)
        {
            var lines = text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                var details = line.Split(',');
                var newRecord = new Record();
                newRecord.parent = details[0];
                newRecord.child = details[1];
                newRecord.amount = Int32.Parse(details[2]);
                database.Add(newRecord);
            }
                

        }
        static void Extrapolate(string text)
        {

            var lines = text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i <= lines.Length - 1; i++)
            {
                var details = lines[i].Split(',');
                var newRecord = new Record();
                newRecord.parent = details[0];
                newRecord.child = details[1];
                newRecord.amount = decimal.Parse(details[2]);
                database.Add(newRecord);
                Savedatabase();
                if (newRecord.parent != newRecord.child)
                {
                    for(int j = 0; j <= lines.Length - 1; j++)
                    {
                        var details2 = lines[j].Split(',');
                        if (newRecord.child == details2[0] && newRecord.parent != details2[0])
                        {
                            newRecord.parent = newRecord.parent;
                            newRecord.child = details2[1];
                            newRecord.amount = (newRecord.amount * decimal.Parse(details2[2]));
                            database.Add(newRecord);
                        }




                    }

                }


            }
            Savedatabase();



        }
        static void Savedatabase()
        {
            string allTextinDB = "";
            foreach (var record in database)
                allTextinDB = allTextinDB + record + Environment.NewLine;
            File.WriteAllText("input.txt", allTextinDB);
        }


        




            

            

                

            // x,y,amount == x,y,amount if(y is first value in another line 
            //create a new line where x is 1st,2nd value in that line, multiplied amount in x,y by new line amount)
        
    }
}
