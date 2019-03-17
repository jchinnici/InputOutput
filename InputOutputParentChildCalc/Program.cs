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
        static Dictionary<int, Record> database = new Dictionary<int, Record>();
        static void Main(string[] args)
        {
            var currentFileData = File.ReadAllText("input.txt");
            LoadDataBase(currentFileData);
            Extrapolate();

            

            StringBuilder sb = new StringBuilder();


            
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
                    newRecord.Id = Int32.Parse(details[0]);
                    newRecord.x = details[1];
                    newRecord.y = details[2];
                    newRecord.amount = decimal.Parse(details[3]);
                    database.Add(newRecord.Id, newRecord);
                }



        }
        static void Savedatabase()
        {
            string allTextinDB = "";
            foreach (var record in database)
                allTextinDB = allTextinDB + record.Value + Environment.NewLine;
            File.WriteAllText("input.txt", allTextinDB);
        }
        static void Extrapolate()
        {

            var record = new Record();
            int maxID = database.Max(x => x.Key);
            for(int i = 0; i <= maxID; i++)
            {
                var parent = record.x;
                var child = record.y;
                decimal orgAmount = record.amount;
                for(int j = 0; j <= maxID; j++)
                {
                    if(child == record.x)
                    {
                        record.Id = maxID + 1;
                        record.x = parent;
                        record.y = record.y;
                        record.amount = (orgAmount * record.amount);
                        database.Add(record.Id, record);
                        maxID = record.Id;
                    }
                }

                
            }
            Savedatabase();

        }




            

            

                

            // x,y,amount == x,y,amount if(y is first value in another line 
            //create a new line where x is 1st,2nd value in that line, multiplied amount in x,y by new line amount)
        
    }
}
