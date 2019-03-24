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
        static List<Record> database2 = new List<Record>();
        static void Main(string[] args)
        {
            var currentFileData = File.ReadAllText("input.txt");

            LoadDataBase(currentFileData);
            


            

            


            
            //File.WriteAllText("input.txt", sb.ToString());
            Console.WriteLine(File.ReadAllText("input.txt"));
            Console.Read();
        }
        static void LoadDataBase(string text)
        {
                var lines = text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            

            for(int i = 0; i <= text.Length - 1; i++)
            {
                var details = lines[i].Split(',');
                var newRecord = new Record();
                newRecord.parent = details[0];
                newRecord.child = details[1];
                newRecord.amount = decimal.Parse(details[2]);
                database.Add(newRecord);
                if(newRecord.parent != newRecord.child)
                {
                    for (int j = 0; i <= text.Length; j++)
                    {
                        var newRecord2 = new Record2();
                        newRecord2.parent2 = details[0];
                        newRecord2.child2 = details[1];
                        newRecord2.amount2 = decimal.Parse(details[2]);
                        if (newRecord.child == newRecord2.parent2)
                        {
                            newRecord.parent = newRecord.parent;
                            newRecord.child = newRecord2.child2;
                            newRecord.amount = (newRecord.amount * newRecord2.amount2);
                            database.Add(newRecord);
                        }
                        else
                        {
                            var shit = "shit";
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
